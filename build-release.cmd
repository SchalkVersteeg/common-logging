REM other targets are:
REM 'build'
REM 'test'
REM 'test-integration'

@ECHO OFF
cls

@echo Building from script Common.Logging.build...
@echo .
@echo .
@echo .

rem tools\nant\bin\nant.exe -f:Common.Logging.build build package-zip package-nuget -D:project.sign=true -D:package.version=3.1.0 -D:nuget.version.suffix=Alpha1 -D:project.releasetype=release > buildlog.txt

SET NANTEXE_PATH=nant.exe
"%NANTEXE_PATH%" -help >NUL: 2>NUL:
IF NOT ERRORLEVEL 1 goto FoundNAnt

REM Try hard coded path for NAnt
SET NANTEXE_PATH=C:\Program Files\NAnt\bin\nant.exe
"%NANTEXE_PATH%" -help >NUL: 2>NUL:
IF NOT ERRORLEVEL 1 goto FoundNAnt

REM Try ToolsPath for nant
SET NANTEXE_PATH=tools\nant\bin\nant.exe
"%NANTEXE_PATH%" -help >NUL: 2>NUL:
IF NOT ERRORLEVEL 1 goto FoundNAnt

REM We have not found NAnt
ECHO.
ECHO NAnt does not appear to be installed. NAnt.exe failed to execute.
ECHO Please ensure NAnt is installed and can be found in the PATH.
GOTO EndError


:FoundNAnt
ECHO NANTEXE_PATH is %NANTEXE_PATH%

REM Setup the build file
IF EXIST Common.Logging.build (
	SET BUILD_FILE=Common.Logging.build
) ELSE (
	SET BUILD_FILE=
)
"%NANTEXE_PATH%" "-buildfile:%BUILD_FILE%" build package-zip package-nuget -D:project.sign=true -D:package.version=3.3.1 -D:project.releasetype=release > buildlog.txt

@echo ...complete!
@echo .
@echo .
@echo .

@echo Launching text file viewer to display buildlog.txt contents...
start "ignored but required placeholder window title argument" buildlog.txt