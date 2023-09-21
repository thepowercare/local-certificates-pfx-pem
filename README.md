
# Create and consume Self-Signed Certificates on Linux

__Prerequisite__

Running in this projects devcontainer

## Create Self-Signed Certificate using 'openssl'

Create with password:

`bash#>` openssl req -x509 -newkey rsa:4096 \
          -keyout certs/linux-test-private-key.pem \
          -out certs/linux-test-cert.pem -days 365 \
          -subj '/CN=localhost'

### Example
`root@03437dd68dcc:/workspaces/LinuxTest#` openssl req -x509 -newkey rsa:4096 \
          -keyout certs/linux-test-private-key.pem \
          -out certs/linux-test-cert.pem -days 365 \
          -subj '/CN=localhost'
Generating a RSA private key
.........................................................++++
.............................................................................................................................................++++
writing new private key to 'certs/linux-test-private-key.pem'
Enter PEM pass phrase:
Verifying - Enter PEM pass phrase:
-----
`root@03437dd68dcc:/workspaces/LinuxTest#`

Here I used the pass phrase: `helloworld`

## Create Self-Signed Certificates using 'dotnet dev-certs'

__Create__
`root@03437dd68dcc:/workspaces/LinuxTest#` dotnet dev-certs https --export-path ./certs/my-dev-cert.pfx --password helloworld
The HTTPS developer certificate was generated successfully

(The development certificate is stored within a platform-dependent certificate store)

__List certs__
`root@03437dd68dcc:/workspaces/LinuxTest#` dotnet dev-certs https
A valid HTTPS certificate is already present.dotnet dev-certs https

__Clean__
`root@03437dd68dcc:/workspaces/LinuxTest#` dotnet dev-certs https --clean
HTTPS development certificates successfully removed from the machine.dotnet dev-certs https --clean