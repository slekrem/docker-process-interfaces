dnvm upgrade
dnu restore

cd ./IDockerProcess/
dnu build --configuration Release
dnu pack --configuration Release

cd ../IDockerMachineProcess/
dnu build --configuration Release
dnu pack --configuration Release

cd ../IDockerComposeProcess/
dnu build --configuration Release
dnu pack --configuration Release
