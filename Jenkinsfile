pipeline {
	agent any
	stages {
		stage ('build') {
			steps {
				echo 'Starting build process...'
			    bat "dotnet build TriangleTesting\\TriangleTesting.csproj --configuration Release"
				echo 'Build process complete'
			}
		}
		stage ('test') {
			steps {
				echo 'Starting testing process...'
				bat "dotnet test Test.TriangleTesting\\Test.TriangleTesting.csproj"
				echo 'Testing process complete'
			}
		}
		stage('deploy') {
			steps {
				echo 'Deploying....'
			}
		}
	}
}