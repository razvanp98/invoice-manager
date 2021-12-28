Prerequisites:

	- MySQL Server (import 'export_db.sql' file) => change DB credentials accordingly in InvoiceRepository.cs
	- MySQL Connector for .NET (otherwise the necessary .dll will not be found)
	- Grant access to not-secure apps in Google Account. If MFA is enabled, then generate a
	password for logging into Google Account from this application. (login needed for email functionality)