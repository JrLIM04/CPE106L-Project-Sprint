﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Game
{
    /// <summary>
    /// Class which holds a collection of words for the hangman game
    /// </summary>
    public class Words : List<Word>
    {
        /// <summary>
        /// Class which holds a collection of words for the hangman game 
        /// </summary>
        public Words()
        {
            this.Add(new Word() { Content = "ABANDON" });
            this.Add(new Word() { Content = "ABILITY" });
            this.Add(new Word() { Content = "ABLE" });
            this.Add(new Word() { Content = "ABORTION" });
            this.Add(new Word() { Content = "ABOUT" });
            this.Add(new Word() { Content = "ABOVE" });
            this.Add(new Word() { Content = "ABROAD" });
            this.Add(new Word() { Content = "ABSENCE" });
            this.Add(new Word() { Content = "APPLICATION" });
            this.Add(new Word() { Content = "BABY" });
            this.Add(new Word() { Content = "BADLY" });
            this.Add(new Word() { Content = "BALANCE" });
            this.Add(new Word() { Content = "BANK" });
            this.Add(new Word() { Content = "BATHROOM" });
            this.Add(new Word() { Content = "BEAT" });
            this.Add(new Word() { Content = "BECOME" });
            this.Add(new Word() { Content = "BEYOND" });
            this.Add(new Word() { Content = "BLANKET" });
            this.Add(new Word() { Content = "BRILLIANT" });
            this.Add(new Word() { Content = "COMPLY" });
            this.Add(new Word() { Content = "CABIN" });
            this.Add(new Word() { Content = "CANDIDATE" });
            this.Add(new Word() { Content = "CASH" });
            this.Add(new Word() { Content = "CATHOLIC" });
            this.Add(new Word() { Content = "CHARGE" });
            this.Add(new Word() { Content = "CHEESE" });
            this.Add(new Word() { Content = "CHANNEL" });
            this.Add(new Word() { Content = "CLINIC" });
            this.Add(new Word() { Content = "COAST" });
            this.Add(new Word() { Content = "DEAD" });
            this.Add(new Word() { Content = "DECREASE" });
            this.Add(new Word() { Content = "DEFEAT" });
            this.Add(new Word() { Content = "DEGREE" });
            this.Add(new Word() { Content = "DEMAND" });
            this.Add(new Word() { Content = "DEPEND" });
            this.Add(new Word() { Content = "DEPT" });
            this.Add(new Word() { Content = "DEED" });
            this.Add(new Word() { Content = "DESIRE" });
            this.Add(new Word() { Content = "DESTROY" });
            this.Add(new Word() { Content = "EASY" });
            this.Add(new Word() { Content = "EARLY" });
            this.Add(new Word() { Content = "EARN" });
            this.Add(new Word() { Content = "EASTERN" });
            this.Add(new Word() { Content = "EIGHT" });
            this.Add(new Word() { Content = "ELITE" });
            this.Add(new Word() { Content = "ELEPHANT" });
            this.Add(new Word() { Content = "ELDERLY" });
            this.Add(new Word() { Content = "ELEMENT" });
            this.Add(new Word() { Content = "ENABLE" });
            this.Add(new Word() { Content = "FAIR" });
            this.Add(new Word() { Content = "FALSE" });
            this.Add(new Word() { Content = "FARMER" });
            this.Add(new Word() { Content = "FAST" });
            this.Add(new Word() { Content = "FAVOR" });
            this.Add(new Word() { Content = "FATHER" });
            this.Add(new Word() { Content = "FEMALE" });
            this.Add(new Word() { Content = "FIFTY" });
            this.Add(new Word() { Content = "FILE" });
            this.Add(new Word() { Content = "FITNESS" });
            this.Add(new Word() { Content = "GATHER" });
            this.Add(new Word() { Content = "GENDER" });
            this.Add(new Word() { Content = "GESTURE" });
            this.Add(new Word() { Content = "GLOBAL" });
            this.Add(new Word() { Content = "GOAL" });
            this.Add(new Word() { Content = "GRADUATE" });
            this.Add(new Word() { Content = "GROCERY" });
            this.Add(new Word() { Content = "GROWING" });
            this.Add(new Word() { Content = "GROWTH" });
            this.Add(new Word() { Content = "GUARD" });
            this.Add(new Word() { Content = "HEART" });
            this.Add(new Word() { Content = "HARDLY" });
            this.Add(new Word() { Content = "HEALTH" });
            this.Add(new Word() { Content = "HEAVEN" });
            this.Add(new Word() { Content = "HEIGHT" });
            this.Add(new Word() { Content = "HELP" });
            this.Add(new Word() { Content = "HEAL" });
            this.Add(new Word() { Content = "HEARING" });
            this.Add(new Word() { Content = "HELPFULL" });
            this.Add(new Word() { Content = "INDENTITY" });
            this.Add(new Word() { Content = "IGNORE" });
            this.Add(new Word() { Content = "ILLEGAL" });
            this.Add(new Word() { Content = "ILLNESS" });
            this.Add(new Word() { Content = "IMAGE" });
            this.Add(new Word() { Content = "IMAGINE" });
            this.Add(new Word() { Content = "IMPLANT" });
            this.Add(new Word() { Content = "IMPORT" });
            this.Add(new Word() { Content = "INCOME" });
            this.Add(new Word() { Content = "INFANT" });
            this.Add(new Word() { Content = "INJURY" });
            this.Add(new Word() { Content = "JOURNAL" });
            this.Add(new Word() { Content = "JOURNEY" });
            this.Add(new Word() { Content = "JUNIOR" });
            this.Add(new Word() { Content = "JUSTICE" });
            this.Add(new Word() { Content = "JUDGE" });
            this.Add(new Word() { Content = "JOKE" });
            this.Add(new Word() { Content = "JOINT" });
            this.Add(new Word() { Content = "JUSTIFY" });
            this.Add(new Word() { Content = "JOY" });
            this.Add(new Word() { Content = "JAIL" });
            this.Add(new Word() { Content = "KEY" });
            this.Add(new Word() { Content = "KING" });
            this.Add(new Word() { Content = "KITCHEN" });
            this.Add(new Word() { Content = "KILLER" });
            this.Add(new Word() { Content = "KICK" });
            this.Add(new Word() { Content = "KNIFE" });
            this.Add(new Word() { Content = "KID" });
            this.Add(new Word() { Content = "KEEP" });
            this.Add(new Word() { Content = "KINGDOM" });
            this.Add(new Word() { Content = "KNOCK" });
            this.Add(new Word() { Content = "LAND" });
            this.Add(new Word() { Content = "LABEL" });
            this.Add(new Word() { Content = "LAUNCH" });
            this.Add(new Word() { Content = "LEADING" });
            this.Add(new Word() { Content = "LEARNING" });
            this.Add(new Word() { Content = "LEATHER" });
            this.Add(new Word() { Content = "LAUGH" });
            this.Add(new Word() { Content = "LEGEND" });
            this.Add(new Word() { Content = "LETTER" });
            this.Add(new Word() { Content = "LIBRARY" });
            this.Add(new Word() { Content = "MACHINE" });
            this.Add(new Word() { Content = "MAKEUP" });
            this.Add(new Word() { Content = "MANAGE" });
            this.Add(new Word() { Content = "MARKET" });
            this.Add(new Word() { Content = "MATERIAL" });
            this.Add(new Word() { Content = "MATCH" });
            this.Add(new Word() { Content = "MEAL" });
            this.Add(new Word() { Content = "MEDIA" });
            this.Add(new Word() { Content = "MEDICINE" });
            this.Add(new Word() { Content = "MEMBER" });
            this.Add(new Word() { Content = "NATURAL" });
            this.Add(new Word() { Content = "NATION" });
            this.Add(new Word() { Content = "NEGATIVE" });
            this.Add(new Word() { Content = "NEITHER" });
            this.Add(new Word() { Content = "NERVOUS" });
            this.Add(new Word() { Content = "NETWORK" });
            this.Add(new Word() { Content = "NORMAL" });
            this.Add(new Word() { Content = "NOTHING" });
            this.Add(new Word() { Content = "NOW" });
            this.Add(new Word() { Content = "NOTICE" });
            this.Add(new Word() { Content = "OBJECT" });
            this.Add(new Word() { Content = "OBSERVE" });
            this.Add(new Word() { Content = "OCCUPY" });
            this.Add(new Word() { Content = "OCEAN" });
            this.Add(new Word() { Content = "OFFICE" });
            this.Add(new Word() { Content = "OFFENSE" });
            this.Add(new Word() { Content = "OFTEN" });
            this.Add(new Word() { Content = "ONE" });
            this.Add(new Word() { Content = "ONION" });
            this.Add(new Word() { Content = "ORANGE" });
            this.Add(new Word() { Content = "PAINTER" });
            this.Add(new Word() { Content = "PALE" });
            this.Add(new Word() { Content = "PARK" });
            this.Add(new Word() { Content = "PARTNER" });
            this.Add(new Word() { Content = "PASSENGER" });
            this.Add(new Word() { Content = "PATIENT" });
            this.Add(new Word() { Content = "PEAK" });
            this.Add(new Word() { Content = "PEEK" });
            this.Add(new Word() { Content = "PEACE" });
            this.Add(new Word() { Content = "PERMIT" });
            this.Add(new Word() { Content = "QUAITY" });
            this.Add(new Word() { Content = "QUICK" });
            this.Add(new Word() { Content = "QUESTION" });
            this.Add(new Word() { Content = "QUARTER" });
            this.Add(new Word() { Content = "QUIETLY" });
            this.Add(new Word() { Content = "QUOTE" });
            this.Add(new Word() { Content = "RACE" });
            this.Add(new Word() { Content = "RARELY" });
            this.Add(new Word() { Content = "REALITY" });
            this.Add(new Word() { Content = "REALIZE" });
            this.Add(new Word() { Content = "REASONABLE" });
            this.Add(new Word() { Content = "RAPID" });
            this.Add(new Word() { Content = "RARE" });
            this.Add(new Word() { Content = "REACTION" });
            this.Add(new Word() { Content = "REASON" });
            this.Add(new Word() { Content = "RED" });
            this.Add(new Word() { Content = "RECENT" });
            this.Add(new Word() { Content = "REALITY" });
            this.Add(new Word() { Content = "REALLY" });
            this.Add(new Word() { Content = "RECOVER" });
            this.Add(new Word() { Content = "SAUCE" });
            this.Add(new Word() { Content = "SAMPLE" });
            this.Add(new Word() { Content = "SAVING" });
            this.Add(new Word() { Content = "SCENARIO" });
            this.Add(new Word() { Content = "SCHOOL" });
            this.Add(new Word() { Content = "SOUR" });
            this.Add(new Word() { Content = "SCIENCE" });
            this.Add(new Word() { Content = "SENIOR" });
            this.Add(new Word() { Content = "SEQUENCE" });
            this.Add(new Word() { Content = "SEGMENT" });
            this.Add(new Word() { Content = "TWO" });
            this.Add(new Word() { Content = "TRAIN" });
            this.Add(new Word() { Content = "TREASURE" });
            this.Add(new Word() { Content = "TABLE" });
            this.Add(new Word() { Content = "TEACHER" });
            this.Add(new Word() { Content = "TEEN" });
            this.Add(new Word() { Content = "TREND" });
            this.Add(new Word() { Content = "TENDENCY" });
            this.Add(new Word() { Content = "TESTIFY" });
            this.Add(new Word() { Content = "TEXT" });
            this.Add(new Word() { Content = "UNDER" });
            this.Add(new Word() { Content = "UNCLE" });
            this.Add(new Word() { Content = "UNIFORM" });
            this.Add(new Word() { Content = "UNIT" });
            this.Add(new Word() { Content = "UNLIKELY" });
            this.Add(new Word() { Content = "UNUSUAL" });
            this.Add(new Word() { Content = "URGE" });
            this.Add(new Word() { Content = "USAGE" });
            this.Add(new Word() { Content = "USUALLY" });
            this.Add(new Word() { Content = "UNKNOWN" });
            this.Add(new Word() { Content = "VALUE" });
            this.Add(new Word() { Content = "VALLEY" });
            this.Add(new Word() { Content = "VARIABLE" });
            this.Add(new Word() { Content = "VAST" });
            this.Add(new Word() { Content = "VARY" });
            this.Add(new Word() { Content = "VEHICLE" });
            this.Add(new Word() { Content = "VANTURE" });
            this.Add(new Word() { Content = "VICTIME" });
            this.Add(new Word() { Content = "VIOLATION" });
            this.Add(new Word() { Content = "VILLAGE" });
            this.Add(new Word() { Content = "WAGE" });
            this.Add(new Word() { Content = "WAX" });
            this.Add(new Word() { Content = "WEALTH" });
            this.Add(new Word() { Content = "WEAPON" });
            this.Add(new Word() { Content = "WEDDING" });
            this.Add(new Word() { Content = "WESTERN" });
            this.Add(new Word() { Content = "WHATEVER" });
            this.Add(new Word() { Content = "WHISPER" });
            this.Add(new Word() { Content = "WHOLE" });
            this.Add(new Word() { Content = "WHALE" });
            this.Add(new Word() { Content = "YARD" });
            this.Add(new Word() { Content = "YESTERDAY" });
            this.Add(new Word() { Content = "YOUNG" });
            this.Add(new Word() { Content = "YOURSELF" });
            this.Add(new Word() { Content = "YEAR" });
            this.Add(new Word() { Content = "YELLOW" });
            this.Add(new Word() { Content = "YELL" });
            this.Add(new Word() { Content = "YOUTH" });
            this.Add(new Word() { Content = "YIELD" });
            this.Add(new Word() { Content = "YACHT" });
            this.Add(new Word() { Content = "ZAG" });
            this.Add(new Word() { Content = "ZAP" });
            this.Add(new Word() { Content = "ZEALOUS" });
            this.Add(new Word() { Content = "ZEBRA" });
            this.Add(new Word() { Content = "ZEROES" });
            this.Add(new Word() { Content = "ZEUS" });
            this.Add(new Word() { Content = "ZIGZAG" });
            this.Add(new Word() { Content = "ZIP" });
            this.Add(new Word() { Content = "ZONE" });
            this.Add(new Word() { Content = "ZYGOTE" });
        }

        /// <summary>
        /// Pick a random word
        /// </summary>
        /// <returns></returns>
        public Word Pick
        {
            get
            {
                Random RandomPick = new Random();
                int index = (int)(RandomPick.NextDouble() * this.Count);
                Word word = this[index];
                word.Content = word.Content.ToUpper();
                return word;
            }
        }
    }
}