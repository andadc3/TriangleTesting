pipeline {
	agent any
	
    environment {
        CONFIGURATION = 'Release'
    } 
	
	stages {
		stage ('Clean workspace') {
		  steps {
			// Using ws-cleanup plugin to clean workspace;
			// Erases any files from prior pipelines execution, to reduce
			// risk of unexpected behavior.
			cleanWs()
		  }
		}
		stage ('Git Checkout') {
			steps {
				// After cleaning the workspace, retrieve the code from Git
				git branch: 'master', credentialsId: '01c686de-7459-493b-8082-890f5a3aadcb', url: 'https://andadc3@github.com/andadc3/TriangleTesting.git'
			}
		}
		stage ('Package Restore') {
			steps {
				// Once the code is retrieved, ensure it has all the packages it needs in order to build
				bat "dotnet restore ${workspace}\\TriangleTesting.sln"
			}
		}
		stage ('Build') {
			steps {
				echo 'Starting build process...'
			    bat "dotnet build TriangleTesting\\TriangleTesting.csproj -c $CONFIGURATION"
				echo 'Build process complete'
			}
		}
		stage ('Unit Tests') {
			steps {
				echo 'Starting testing process...'
				bat "dotnet test Test.TriangleTesting\\Test.TriangleTesting.csproj"
				echo 'Testing process complete'
			}
		}
		stage('Deploy') {
			steps {
				echo 'Deployment stage not yet configured.'
			}
		}
	}
}