@echo off
title WoW Interface Backup

:: CONFIG ::::::::::::::::::::::::::::::::::::::::::::::::
:: Path to the WoW folder, without trailing \
SET WoWPath=C:\Program Files (x86)\World of Warcraft

:: Path to the backup folder, without trailing \
SET BackupLocation=C:\Users\local_p3m6d12\OneDrive\Backups

:: Path to the 7za.exe file, without trailing \
SET SevenZipPath=C:\tools\7z
:: END CONFIG ::::::::::::::::::::::::::::::::::::::::::::::::

for /f %%x in ('wmic path win32_localtime get /format:list ^| findstr "="') do set %%x
set today=%Day%_%Month%_%YEAR%-%HOUR%%MINUTE%

%SevenZipPath%\7za.exe a -mx9 "%BackupLocation%\WoW_InterfaceBackup_%today%" -r "%WoWPath%\Interface" "%WoWPath%\WTF"

echo Done
timeout /t 15
exit