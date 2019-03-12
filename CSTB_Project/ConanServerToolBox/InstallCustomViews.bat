for %%a in (game.db) do (
echo "%%a"
CSTB_sqlite %%a < CustomViews.sql
)
@echo Updated Custom Views
close