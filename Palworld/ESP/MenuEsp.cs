using ImGuiNET;
using Palworld.Core;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawSettings()
        {
            if (ImGui.Begin("Settings"))
            {
                var colorEditFlags = ImGuiColorEditFlags.AlphaPreview | ImGuiColorEditFlags.PickerHueWheel | ImGuiColorEditFlags.NoInputs;
                var headerHeight = 20;

                ImGui.BeginTable("EspSettings", 4, ImGuiTableFlags.Borders);
                ImGui.TableNextRow(ImGuiTableRowFlags.Headers, headerHeight);
                ImGui.TableNextColumn(); ImGui.Text("ESP");
                ImGui.TableNextColumn(); ImGui.Text("Enabled");
                ImGui.TableNextColumn(); ImGui.Text("Color");
                ImGui.TableNextColumn(); ImGui.Text("Distance");
                ImGui.TableNextColumn(); ImGui.Text("Pal");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnablePal", ref Settings.EnablePal);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##PalColor", ref Settings.PalColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##PalDistance", ref Settings.PalDistance);
                ImGui.EndTable();

                if (ImGui.Button("Save"))
                    Settings.Save();
            }

            ImGui.End();
        }
    }
}
