pipeline {
	agent any
	stages {
		stage ('build') {
			steps {
				echo 'Starting build process...'
			    dotnet build
				echo 'Build process complete'
			}
		}
		stage ('test') {
			steps {
				echo 'Testing..'
			}
		}
		stage('deploy') {
			steps {
				echo 'Deploying....'
			}
		}
	}
}