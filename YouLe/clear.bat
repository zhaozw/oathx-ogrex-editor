@echo off
echo 清除所有obj pch idb pdb ncb opt plg res sbr ilk suo文件，请稍等......
pause
del /f /s /q .\*.obj
del /f /s /q .\*.pch
del /f /s /q .\*.idb
del /f /s /q .\*.pdb
del /f /s /q .\*.ncb 
del /f /s /q .\*.opt 
del /f /s /q .\*.plg
del /f /s /q .\*.res
del /f /s /q .\*.sbr
del /f /s /q .\*.ilk
del /f /s /q .\*.aps
del /f /s /q .\*.htm
del /f /s /q .\*.tlh
del /f /s /q .\*.tli
del /f /s /q .\*.suo
del /f /s /q .\Debug
del /f /s /q .\Release

echo 清除文件完成！
echo. & pause