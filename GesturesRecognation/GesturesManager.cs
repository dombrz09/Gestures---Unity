using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public class GesturesManager
    {
        private string gestureFlag = "";
        private bool recogtationGestureFlag = false;
        private bool activeFlagAd = false;
        private bool activeFlagPp = false;
        private bool activeFlagGc = false;
        private bool startActionFlagAd = false;
        private bool startActionFlagPp = false;
        private bool startActionFlagGc = false;
        private int currentZoom = 0;
        public int exitCounter = 0;
        public ProgramsController program = new ProgramsController();

        public void setGestureFlag(string gesture)
        {
            this.gestureFlag = gesture;
        }

        public void setrecogtationGestureFlag(bool var)
        {
            this.recogtationGestureFlag = var;
        }

        public string getGestureFlag()
        {
            return this.gestureFlag;
        }

        public bool getrecogtationGestureFlag()
        {
            return this.recogtationGestureFlag;
        }

        public void setActiveFlagAd(bool var)
        {
            this.activeFlagAd = var;
        }

        public bool getActiveFlagAd()
        {
            return this.activeFlagAd;
        }

        public void setActiveFlagPp(bool var)
        {
            this.activeFlagPp = var;
        }

        public bool getActiveFlagPp()
        {
            return this.activeFlagPp;
        }

        public void setStartActionFlagAd(bool var)
        {
            this.startActionFlagAd = var;
        }

        public bool getStartActionFlagAd()
        {
            return this.startActionFlagAd;
        }

        public void setStartActionFlagPp(bool var)
        {
            this.startActionFlagPp = var;
        }

        public bool getStartActionFlagPp()
        {
            return this.startActionFlagPp;
        }

        public void setStartActionFlagGc(bool var)
        {
            this.startActionFlagGc = var;
        }

        public bool getStartActionFlagGc()
        {
            return this.startActionFlagGc;
        }

        public void setActiveFlagGc(bool var)
        {
            this.activeFlagGc = var;
        }

        public bool getActiveFlagGc()
        {
            return this.activeFlagGc;
        }

        public void setPointerMouse()
        {
            if(program.getCurrentProgram() == "Gc")
            {
                program.pointer_Mouse(this, null);
            }
        }

        public void doAction(string gesture)
        {
            if (gesture == "start")
            {
                System.Diagnostics.Debug.WriteLine("program.getCurrentProgram() "+ program.getCurrentProgram());
                if ((getActiveFlagAd() == false) && (program.getCurrentProgram() == "Ad"))
                {
                    if (getStartActionFlagAd() == false)
                    {
                        program.start_Click(this, null);
                        setStartActionFlagAd(true);
                    }
                    setActiveFlagAd(true);
                }
                else if ((getActiveFlagPp() == false) && (program.getCurrentProgram() == "Pp"))
                {
                    if (getStartActionFlagPp() == false)
                    {
                        program.start_Click(this, null);
                        setStartActionFlagPp(true);
                    }
                    setActiveFlagPp(true);
                }
                else if ((getActiveFlagGc() == false) && (program.getCurrentProgram() == "Gc"))
                {
                    if (getStartActionFlagGc() == false)
                    {
                        program.start_Click(this, null);
                        setStartActionFlagGc(true);
                    }
                    setActiveFlagGc(true);
                }
            }
            else if (gesture == "next")
            {
                program.next_Click(this, null);
            }
            else if (gesture == "previous")
            {
                program.previous_Click(this, null);
            }
            else if (gesture == "zoom_in")
            {
                if(program.getCurrentProgram() == "Pp")
                {
                    if(this.currentZoom < 3)
                    {
                        this.currentZoom++;
                        program.zIn_Click(this, null);
                    }
                }
                else
                {
                    program.zIn_Click(this, null);
                }
                
            }
            else if (gesture == "zoom_out")
            {
                if (program.getCurrentProgram() == "Pp")
                {
                    if (this.currentZoom > 0)
                    {
                        this.currentZoom--;
                        program.zOut_Click(this, null);
                    }
                }
                else
                {
                    program.zOut_Click(this, null);
                }
            }
            else if (gesture == "right")
            {
                program.right_Click(this, null);
            }
            else if (gesture == "left")
            {
                program.left_Click(this, null);
            }
            else if (gesture == "scroll_up")
            {
                program.scroll_up_Click(this, null);
            }
            else if (gesture == "scroll_down")
            {
                program.scroll_down_Click(this, null);
            }
        }
    }
}
