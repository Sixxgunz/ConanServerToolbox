@echo off
for %%a in (game.db) do (
echo "%%a"
CSTB_sqlite %%a < freshwipe.sql
)
pause