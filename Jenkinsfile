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
				// ${workspace} leads to the jenkins workspace for the pipeline job
				// Workspace can be seen in Jenkins by clicking on a build -> Workspaces
				// The restore command requires ${workspace}\\<path-to-solutiin>\\<solution-name>.sln,
				// where <path-to-solution> may or may not apply (.sln might be in workspace, as in our case)
				bat "dotnet restore ${workspace}\\TriangleTesting.sln"
			}
		}
		stage ('Clean solution') {
			steps {
				// Clean the solution, before building
				// MSBuild.exe must exist in windows environment variables;
				// Params for msbuild.exe can be understood here https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-command-line-reference
				// The clean is instructed by /t:clean
				bat "\"${tool 'MSBuildVS2019'}" ${workspace}\\TriangleTesting.sln -nologo /p:platform=\"x64\" /p:configuration=\"release\" /t:clean"
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