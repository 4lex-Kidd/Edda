﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BPMChange {
    public double globalBeat { get; set; }
    public double BPM { get; set; }
    public int gridDivision { get; set; }

    public BPMChange(double globalBeat, double BPM, int gridDivision) {
        this.globalBeat = globalBeat;
        this.BPM = BPM;
        this.gridDivision = gridDivision;
    }

    public BPMChange() : this(0, 120, 4) { }
}