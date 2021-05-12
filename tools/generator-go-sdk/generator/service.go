package generator

import (
	"fmt"
	"log"
	"os"
	"os/exec"

	"github.com/hashicorp/pandora/tools/sdk/services"
)

type ServiceGenerator struct {
	settings Settings
}

func NewServiceGenerator(settings Settings) ServiceGenerator {
	return ServiceGenerator{
		settings: settings,
	}
}

type ServiceGeneratorInput struct {
	ServiceName     string
	ServiceDetails  services.ResourceManagerService
	VersionName     string
	VersionDetails  services.ServiceVersion
	ResourceName    string
	ResourceDetails services.Resource
	OutputDirectory string
}

func (s *ServiceGenerator) Generate(input ServiceGeneratorInput) error {
	data := input.generatorData()

	if err := cleanAndRecreateWorkingDirectory(data.outputPath); err != nil {
		return fmt.Errorf("cleaning/recreating working directory %q: %+v", data.outputPath, err)
	}

	stages := map[string]func(data ServiceGeneratorData) error{
		"clients":   s.clients,
		"constants": s.constants,
		"ids":       s.ids,
		"methods":   s.methods,
		"models":    s.models,
		"version":   s.version,
	}
	for name, stage := range stages {
		log.Printf("[DEBUG] Running Stage %q..", name)
		if err := stage(data); err != nil {
			return fmt.Errorf("generating %s: %+v", name, err)
		}
	}

	runGoFmt(data.outputPath)

	return nil
}

func runGoFmt(path string) {
	cmd := exec.Command("gofmt", "-w", path)
	_ = cmd.Start()
	_ = cmd.Wait()
}

func cleanAndRecreateWorkingDirectory(path string) error {
	os.RemoveAll(path)
	// TODO: make these less exciting
	if err := os.MkdirAll(path, 0777); err != nil {
		return fmt.Errorf("creating %q: %+v", path, err)
	}

	return nil
}
