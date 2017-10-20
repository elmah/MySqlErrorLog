@echo off
pushd "%~dp0"
call :main %*
popd
goto :EOF

:main
setlocal
nuget restore ^
 && (for %%c in (Debug Release) do call msbuild "/p:Configuration=%%c" /v:m %* || exit /b 1)
goto :EOF
