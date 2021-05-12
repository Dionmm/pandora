package resourcemanager

import (
	"encoding/json"
	"fmt"
)

type ServiceDetailsClient struct {
	Client
}

func (c ServiceDetailsClient) Get(input ServiceSummary) (*ServiceDetails, error) {
	endpoint := fmt.Sprintf("%s%s", c.endpoint, input.Uri)
	resp, err := c.client.Get(endpoint)
	if err != nil {
		return nil, err
	}

	// TODO: handle this being a 404 etc

	var response ServiceDetails
	if err := json.NewDecoder(resp.Body).Decode(&response); err != nil {
		return nil, err
	}

	return &response, nil
}

type ServiceDetails struct {
	// ResourceProvider is the Resource Provider this service represents
	ResourceProvider string `json:"resourceProvider,omitempty"`

	// Versions is a summary of the Versions available for this Service
	Versions map[string]ServiceVersion `json:"versions"`

	// Terraform is a summary of Terraform related metadata
	Terraform TerraformSummary `json:"terraform"`
}

type ServiceVersion struct {
	// Generate specifies whether this should be generated
	Generate bool `json:"generate"`

	// Preview specifies whether or not this is a Preview API
	Preview bool `json:"preview"`

	// Uri is a reference to more details about this Service Version
	Uri string `json:"uri"`
}

type TerraformObjectSummary struct {
	// Generate specifies whether this should be generated
	Generate bool `json:"generate"`

	// Uri is a reference to more details about this Terraform Object
	Uri string `json:"uri"`
}

type TerraformSummary struct {
	// DataSources is a map of Terraform data source names to object summaries
	DataSources map[string]TerraformObjectSummary `json:"dataSources"`

	// Resources is a map of Terraform resource names to object summaries
	Resources map[string]TerraformObjectSummary `json:"resources"`
}