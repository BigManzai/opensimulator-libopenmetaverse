@echo OFF

bin\Prebuild.exe /target vs2019 /file prebuild48.xml

setlocal ENABLEEXTENSIONS
set VALUE_NAME=MSBuildToolsPath


rem Try to find VS2019/22
for %%e in (Community Enterprise Professional) do (
    if exist "%PROGRAMS64%\Microsoft Visual Studio\2022\%%e\MSBuild\Current\Bin\MSBuild.exe" (

        set ValueValue="%PROGRAMS64%\Microsoft Visual Studio\2022\%%e\MSBuild\Current\Bin\MSBuild"
		goto :found
    )
    if exist "%PROGRAMS%\Microsoft Visual Studio\2019\%%e\MSBuild\Current\Bin\MSBuild.exe" (

        set ValueValue="%PROGRAMS%\Microsoft Visual Studio\2019\%%e\MSBuild\Current\Bin\MSBuild"
		goto :found
    )
)


for %%X in (grep.exe) do (set FOUNDGREP=%%~$PATH:X)
if defined FOUNDGREP (
  set FINDCMD=grep
) else (
  set FINDCMD=find
)

rem try vs2015
FOR /F "usebackq tokens=1-3" %%A IN (`REG QUERY "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v %VALUE_NAME% 2^>nul ^| %FINDCMD% "%VALUE_NAME%"`) DO (
	set ValueValue=%%C
	goto :found
)

@echo msbuild for at least VS2019 not found, please install a (Community) edition of VS2019
@echo Not creating compile.bat
if exist "compile.bat" (
	del compile.bat
	)
goto :done

:found
    @echo Found msbuild at %ValueValue%
    @echo Creating compile.bat
rem To compile in debug mode
    @echo %ValueValue% opensim.sln > compile.bat
rem To compile in release mode comment line (add rem to start) above and uncomment next (remove rem)
rem    @echo %ValueValue% /p:Configuration=Release opensim.sln > compile.bat
:done

pause