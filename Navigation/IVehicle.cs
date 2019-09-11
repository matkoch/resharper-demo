using System;
using System.Linq;

namespace Demo.Navigation
{
    /* Navigation Features:
     * 
     *   - Alter+Enter (Options, Command Prompt, Regular Expression, ...)
     * 
     *   - NavInt
     *   - NIT (Include libraries)
     *   - Expand to Find Results
     *   - Decompiled Sources
     *   
     *   - Test Vehicle
     *   - VehicleBase
     *   - Locate in Solution Explorer (VehicleBase)
     *   - Goto FileMembers (VehicleBase)
     *   - Goto Base/Derived (VehicleBase)
     *   - Type Hierarchy
     *   - Goto Related Files (VehicleBase)
     *
     *   - Exposing APIs (IVehicle)
     *   - Goto Usages (IVehicle.Move)
     *   - Find Usages + Advanced
     *   
     *   - Extension methods (IVehicle)
     *   - Implementing methods (VehicleBase)
     *   - Value Origin (VehicleTest, car.Seats)
     *   
     *   - To-do Explorer
     *   - Bookmarks
     *   - Goto Recent Files/Edits
     *   
     *   - Goto Text: Ipsum -> QuickFixes
     *   - IL Viewer
     *   
     */
    public interface IVehicle
    {
        int Seats { get; }
        int MaximumVelocity { get; }
        Position Position { get; }

        void Move (int xOffset, int yOffset);
        void Move (Position offset);
    }
}
