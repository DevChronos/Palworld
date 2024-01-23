using ClickableTransparentOverlay;
using ImGuiNET;
using Palworld.Core;

namespace Palworld.ESP
{
    public partial class Esp : Overlay
    {
        public Esp() : base("GeForceNow")
        {
        }

        protected override Task PostInitialized()
        {
            Size = new System.Drawing.Size(1920, 1080);
            VSync = false;

            ImGui.GetStyle().WindowRounding = 5;
            Engine.StartUpdateThread();

            return base.PostInitialized();
        }

        protected override void Render()
        {
            ImGui.SetNextWindowPos(ImGui.GetMainViewport().Pos);
            ImGui.SetNextWindowSize(ImGui.GetMainViewport().Size);
            ImGui.Begin("Main", ImGuiWindowFlags.NoBackground | ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoInputs);

            if (Engine.Memory.IsGameRunning)
            {
                try
                {
                    DrawSettings();
                    DrawPlayers();
                    DrawPals();
                    DrawTreasures();
                    DrawItems();

                    //DebugEntities();
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }
            }

            ImGui.End();
            Thread.Sleep(1);
        }
    }
}
