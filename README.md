
# DotnetGrafana - Customer CRUD API

This project is a minimalistic implementation of a .NET Core Web API for managing customer data with CRUD (Create, Read, Update, Delete) operations. The API is integrated with Prometheus for metrics collection and Grafana for visualization, all running in Docker containers.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Project Structure](#project-structure)
- [Setup and Run](#setup-and-run)
  - [Building the Docker Containers](#building-the-docker-containers)
  - [Running the API](#running-the-api)
  - [Accessing Prometheus](#accessing-prometheus)
  - [Accessing Grafana](#accessing-grafana)
- [API Endpoints](#api-endpoints)
- [Monitoring](#monitoring)
  - [Prometheus Configuration](#prometheus-configuration)
  - [Grafana Dashboards](#grafana-dashboards)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

## Project Structure

```
.
├── bin/
├── obj/
├── Properties/
├── appsettings.Development.json
├── appsettings.json
├── Customer.cs
├── CustomersController.cs
├── docker-compose.yml
├── Dockerfile
├── DotnetGrafana.csproj
├── DotnetGrafana.csproj.user
├── DotnetGrafana.http
├── Program.cs
└── prometheus.yml
```

### Key Files

- **Customer.cs**: Defines the Customer model.
- **CustomersController.cs**: Implements the CRUD operations for the Customer entity.
- **Program.cs**: Configures and runs the web API.
- **Dockerfile**: Defines the Docker image for the .NET Core API.
- **docker-compose.yml**: Orchestrates the API, Prometheus, and Grafana services.
- **prometheus.yml**: Configuration file for Prometheus.

## Setup and Run

### Building the Docker Containers

To build and run the Docker containers for the API, Prometheus, and Grafana, follow these steps:

```bash
docker-compose up --build
```

### Running the API

Once the containers are up, the API will be available at:

```plaintext
http://localhost:5000/customers
```

### Accessing Prometheus

Prometheus will be available at:

```plaintext
http://localhost:9090
```

### Accessing Grafana

Grafana will be available at:

```plaintext
http://localhost:3000
```

- **Default Login:** 
  - Username: `admin`
  - Password: `admin`

After logging in, you can set up a Prometheus data source in Grafana and start building dashboards.

## API Endpoints

- **GET /customers**: Retrieves all customers.
- **GET /customers/{id}**: Retrieves a specific customer by ID.
- **POST /customers**: Creates a new customer.
- **PUT /customers/{id}**: Updates an existing customer by ID.
- **DELETE /customers/{id}**: Deletes a customer by ID.

## Monitoring

### Prometheus Configuration

Prometheus scrapes metrics from the API, which can be configured via the `prometheus.yml` file. By default, Prometheus scrapes metrics from the API every 5 seconds.

### Grafana Dashboards

In Grafana, you can create custom dashboards to visualize metrics from Prometheus. Set up Prometheus as a data source and explore various metrics collected from your API.

## Contributing

Contributions are welcome! Please fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
