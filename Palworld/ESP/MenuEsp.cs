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
                ImGui.TableNextColumn(); ImGui.Text("Player");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnablePlayer", ref Settings.EnablePlayer);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##PlayerColor", ref Settings.PlayerColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##PlayerDistance", ref Settings.PlayerDistance);
                ImGui.TableNextColumn(); ImGui.Text("Pal");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnablePal", ref Settings.EnablePal);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##PalColor", ref Settings.PalColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##PalDistance", ref Settings.PalDistance);
                ImGui.TableNextColumn(); ImGui.Text("Treasure");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnableTreasure", ref Settings.EnableTreasure);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##TreasureColor", ref Settings.TreasureColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##TreasureDistance", ref Settings.TreasureDistance);
                ImGui.TableNextColumn(); ImGui.Text("Item");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnableItem", ref Settings.EnableItem);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##ItemColor", ref Settings.ItemColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##ItemDistance", ref Settings.ItemDistance);
                ImGui.TableNextColumn(); ImGui.Text("Note");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnableNote", ref Settings.EnableNote);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##NoteColor", ref Settings.NoteColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##NoteDistance", ref Settings.NoteDistance);
                ImGui.TableNextColumn(); ImGui.Text("Relic");
                ImGui.TableNextColumn(); ImGui.Checkbox("##EnableRelic", ref Settings.EnableRelic);
                ImGui.TableNextColumn(); ImGui.ColorEdit4("##RelicColor", ref Settings.RelicColor, colorEditFlags);
                ImGui.TableNextColumn(); ImGui.DragInt("##RelicDistance", ref Settings.RelicDistance);
                ImGui.EndTable();

                if (ImGui.Button("Save"))
                    Settings.Save();
            }

            ImGui.End();
        }
    }
}
