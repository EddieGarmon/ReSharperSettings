@echo off
cd ..
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "./cake.ps1 -verbosity \"Verbose\" -Target \"Build\""
Pause