@echo off
cd /d "%~dp0"

echo Stopping any running Stella instance...
taskkill /F /IM Stella.exe >nul 2>&1

for /f "tokens=5" %%p in ('netstat -ano ^| findstr ":3003" ^| findstr "LISTENING"') do (
    taskkill /F /PID %%p >nul 2>&1
)

echo Starting Stella...
dotnet run --launch-profile http
if errorlevel 1 (
    echo.
    echo Stella failed to start.
    pause
)
