using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Linq;
using MuMech;

namespace RasterJeb
{
  public class MechMessenger : InternalModule
  {
    [KSPField]
    public int buttonUp;
    [KSPField]
    public int buttonDown = 1;
    [KSPField]
    public int buttonEnter = 2;
    [KSPField]
    public int buttonEsc = 3;
    
    public override void OnUpdate()
    {
      if (!HighLogic.LoadedSceneIsFlight || vessel != FlightGlobals.ActiveVessel || !pageActiveState)
                                return;
    }
    public void begin()
    {
      if (!HighLogic.LoadedSceneIsFlight)
                                return;
    }
  }
