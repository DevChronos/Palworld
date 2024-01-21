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
            ImGui.GetStyle().WindowRounding = 5;
            Engine.StartUpdateThread();

            return Task.CompletedTask;
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
                    DrawPals();
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
