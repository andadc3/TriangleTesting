pipeline {
	agent any
	environment {
       env.Path = "${env.Path};C:\\Windows\\System32"
   }
	stages {
		stage ('build') {
			steps {
				echo 'Starting build process...'
			    bat 'make'
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