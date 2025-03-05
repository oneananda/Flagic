# Flagic

Flagic (Flag + Magic = Feature Flag Managment like Magic :) ) is an open source web application that provides a comprehensive solution for feature flag management and remote configuration. It offers a centralized dashboard to manage projects, environments, and secure cloud vault integrations, empowering teams to control and roll out features dynamically across various stages of development.

## Table of Contents

- [Features](#features)
- [Architecture](#architecture)

## Features

- **Centralized Dashboard:**  
  Manage all your projects, environments, and feature flags from one intuitive web interface.

- **Environment Management:**  
  Configure separate settings for development, staging, and production, with clear visual segregation.

- **Admin Access & RBAC:**  
  Secure authentication and role-based access control ensure that only authorized users can modify configurations.

- **Cloud Vault Connectors:**  
  Seamless integration with popular cloud vault services such as:
  - AWS Secrets Manager
  - Azure Key Vault
  - HashiCorp Vault
  - GCP Secret Manager

- **Real-Time Updates:**  
  Propagate configuration changes efficiently using polling or push-based mechanisms.

- **Audit Logging:**  
  Maintain detailed logs of administrative actions and configuration changes for enhanced security and compliance.

- **Modular & Extensible:**  
  Easily extend the platform with new connectors, environments, or features as your needs evolve.

## Architecture

Flagic is designed with a modular architecture to support scalability and ease of maintenance:

- **Frontend:**  
  A responsive web dashboard built using modern JavaScript framework React that provides an intuitive interface for managing configurations and monitoring project statuses.

- **Backend API:**  
  A robust API layer using **asp.net cor web api** handling business logic, authentication, and secure integration with cloud vault services.

- **Database:**  
  A scalable data store for persisting configuration data, audit logs, and user information.

- **Cloud Vault Integrations:**  
  Pluggable modules that allow for secure connectivity to various cloud vault providers for managing secrets.

---