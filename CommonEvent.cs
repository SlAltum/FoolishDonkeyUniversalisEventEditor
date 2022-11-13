using System;
using System.Collections.Generic;

namespace FoolishDonkeyUniversalis{
    
    [Serializable]
    public class EventsData {
        public string eventFilePath = "\\events\\";
        public string locFilePath = "\\localisation\\";
        public List<Namespace> namespaces = new List<Namespace>{new Namespace()};
    }
    [Serializable]
    public class Namespace {
        public Namespace(string name="NewNamespace"){
            this.name = name;
        }
        public string name = "NewNamespace";
        public List<CommonEvent> events = new List<CommonEvent>{new CommonEvent()};
    }
    [Serializable]
    public class CommonEvent {
        public CommonEvent(string title="新事件"){
            this.title = title;
        }
        public enum EventType{
            country_event,
            province_event
        }
        public string title = "新事件";
        public string desc = "这是事件描述";
        public string eventPicture = "";
        public EventType eventType;
        public bool triggeredOnly = true;
        public string mtth = "";
        public bool fireOnlyOnce = false;
        public bool hidden = false;
        public string trigger = "";
        public string immediate = "";
        public List<Option> options = new List<Option>{new Option()};
    }
    [Serializable]
    public class Option {
        public string name = "新选项";
        public string trigger = "";
        public string effect = "";
        public bool highlight = false;
    }
}