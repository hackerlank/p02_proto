//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: pb_30.proto
// Note: requires additional types generated from: pb_common.proto
namespace pb_30
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pbTaskList")]
  public partial class pbTaskList : global::ProtoBuf.IExtensible
  {
    public pbTaskList() {}
    
    private readonly global::System.Collections.Generic.List<pb_30.pbTask> _update = new global::System.Collections.Generic.List<pb_30.pbTask>();
    [global::ProtoBuf.ProtoMember(1, Name=@"update", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pb_30.pbTask> update
    {
      get { return _update; }
    }
  
    private readonly global::System.Collections.Generic.List<pb_30.pbTask> _delete = new global::System.Collections.Generic.List<pb_30.pbTask>();
    [global::ProtoBuf.ProtoMember(2, Name=@"delete", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pb_30.pbTask> delete
    {
      get { return _delete; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pbTask")]
  public partial class pbTask : global::ProtoBuf.IExtensible
  {
    public pbTask() {}
    
    private int? _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id?? default(int); }
      set { _id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool idSpecified
    {
      get { return this._id != null; }
      set { if (value == (this._id== null)) this._id = value ? this.id : (int?)null; }
    }
    private bool ShouldSerializeid() { return idSpecified; }
    private void Resetid() { idSpecified = false; }
    
    private int? _task_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"task_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int task_id
    {
      get { return _task_id?? default(int); }
      set { _task_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool task_idSpecified
    {
      get { return this._task_id != null; }
      set { if (value == (this._task_id== null)) this._task_id = value ? this.task_id : (int?)null; }
    }
    private bool ShouldSerializetask_id() { return task_idSpecified; }
    private void Resettask_id() { task_idSpecified = false; }
    
    private long? _player_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id?? default(long); }
      set { _player_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool player_idSpecified
    {
      get { return this._player_id != null; }
      set { if (value == (this._player_id== null)) this._player_id = value ? this.player_id : (long?)null; }
    }
    private bool ShouldSerializeplayer_id() { return player_idSpecified; }
    private void Resetplayer_id() { player_idSpecified = false; }
    
    private int? _type;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type?? default(int); }
      set { _type = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool typeSpecified
    {
      get { return this._type != null; }
      set { if (value == (this._type== null)) this._type = value ? this.type : (int?)null; }
    }
    private bool ShouldSerializetype() { return typeSpecified; }
    private void Resettype() { typeSpecified = false; }
    
    private int? _schedule;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"schedule", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int schedule
    {
      get { return _schedule?? default(int); }
      set { _schedule = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool scheduleSpecified
    {
      get { return this._schedule != null; }
      set { if (value == (this._schedule== null)) this._schedule = value ? this.schedule : (int?)null; }
    }
    private bool ShouldSerializeschedule() { return scheduleSpecified; }
    private void Resetschedule() { scheduleSpecified = false; }
    
    private int? _state;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int state
    {
      get { return _state?? default(int); }
      set { _state = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool stateSpecified
    {
      get { return this._state != null; }
      set { if (value == (this._state== null)) this._state = value ? this.state : (int?)null; }
    }
    private bool ShouldSerializestate() { return stateSpecified; }
    private void Resetstate() { stateSpecified = false; }
    
    private int? _last_op;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"last_op", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int last_op
    {
      get { return _last_op?? default(int); }
      set { _last_op = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool last_opSpecified
    {
      get { return this._last_op != null; }
      set { if (value == (this._last_op== null)) this._last_op = value ? this.last_op : (int?)null; }
    }
    private bool ShouldSerializelast_op() { return last_opSpecified; }
    private void Resetlast_op() { last_opSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}