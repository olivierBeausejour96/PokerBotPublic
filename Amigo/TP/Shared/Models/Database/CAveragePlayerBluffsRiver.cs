﻿using Amigo.Models.MyModels.GameState;

namespace Shared.Models.Database
{
    public class CAveragePlayerBluffsRiver
    {
        public CRiverGameState PGameState { get; }
        public ushort PBoardType { get; }
        public double PBoardHeat { get; }
        public bool PIsStraightDraw { get; }
        public bool PIsFlushDraw { get; }
        public sbyte PIndexHighestCardExcludingBoard { get; } // Because SQLite uses unsigned data types
        public double PUnifiedCount { get; }
        public long PSampleCount { get; }

        public CAveragePlayerBluffsRiver(CRiverGameState _riverGameState, ushort _boardType, double _boardHeat, bool _isStraightDraw, bool _isFlushDraw, sbyte _indexHighestCardExcludingBoard, double _unifiedCount, long _sampleCount)
        {
            PGameState = _riverGameState;
            PBoardType = _boardType;
            PBoardHeat = _boardHeat;
            PIsStraightDraw = _isStraightDraw;
            PIsFlushDraw = _isFlushDraw;
            PIndexHighestCardExcludingBoard = _indexHighestCardExcludingBoard;
            PUnifiedCount = _unifiedCount;
            PSampleCount = _sampleCount;
        }
    }
}