sqllocaldb stop v11.0

copy /Y "Timesheet-v1.0.mdf" "..\Timesheet\Timesheet-v1.0.mdf"

copy /Y "Timesheet-v1.0_log.ldf" "..\Timesheet\Timesheet-v1.0_log.ldf"

sqllocaldb start v11.0

pause