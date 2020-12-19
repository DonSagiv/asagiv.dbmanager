SonarScanner.MSBuild.exe begin /k:"asagiv.dbmanager" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="307e4eb2e9ff4863098b100b5782cdcdfa8226c5"
dotnet clean && dotnet build
SonarScanner.MSBuild.exe end /d:sonar.login="307e4eb2e9ff4863098b100b5782cdcdfa8226c5"