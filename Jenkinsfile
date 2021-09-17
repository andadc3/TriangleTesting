pipeline {
	agent any
	environment {
       env.PATH = env.PATH + ";c:\\Windows\\System32"
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