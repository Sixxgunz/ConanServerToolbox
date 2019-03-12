@echo Inactive Cleanout In Progress
for %%a in (game.db) do (
echo "%%a"
CSTB_sqlite %%a < InactiveCleanout.sql

)
wait