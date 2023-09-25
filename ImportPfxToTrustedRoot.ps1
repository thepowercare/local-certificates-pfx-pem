# Import-Certificate.ps1

param (
    [string]$Password
)

# Validate that the password is not empty
if (-Not $Password) {
    Write-Host "Password must be provided."
    return
}

# Create a Secure Password
$SecurePassword = ConvertTo-SecureString -String $Password -Force -AsPlainText

# File path to the certificate (hardcoded)
$FilePath = "./certs/letsgo.out.pfx"
# $FilePath = "./certs/linux-test-cert.pem"

# Import PFX Certificate into Trusted Root Certification Authorities store
Import-PfxCertificate -FilePath $FilePath -CertStoreLocation "Cert:\LocalMachine\Root" -Password $SecurePassword
