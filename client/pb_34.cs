//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: pb_34.proto
// Note: requires additional types generated from: pb_common.proto
namespace pb_34
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pbTwistEgg")]
  public partial class pbTwistEgg : global::ProtoBuf.IExtensible
  {
    public pbTwistEgg() {}
    
    private int? _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private int? _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int count
    {
      get { return _count?? default(int); }
      set { _count = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool countSpecified
    {
      get { return this._count != null; }
      set { if (value == (this._count== null)) this._count = value ? this.count : (int?)null; }
    }
    private bool ShouldSerializecount() { return countSpecified; }
    private void Resetcount() { countSpecified = false; }
    
    private int? _add_att_flag;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"add_att_flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int add_att_flag
    {
      get { return _add_att_flag?? default(int); }
      set { _add_att_flag = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool add_att_flagSpecified
    {
      get { return this._add_att_flag != null; }
      set { if (value == (this._add_att_flag== null)) this._add_att_flag = value ? this.add_att_flag : (int?)null; }
    }
    private bool ShouldSerializeadd_att_flag() { return add_att_flagSpecified; }
    private void Resetadd_att_flag() { add_att_flagSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<int> _goods_id = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"goods_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> goods_id
    {
      get { return _goods_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pbActivity")]
  public partial class pbActivity : global::ProtoBuf.IExtensible
  {
    public pbActivity() {}
    
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
    
    private string _activity_desc;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"activity_desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string activity_desc
    {
      get { return _activity_desc?? ""; }
      set { _activity_desc = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool activity_descSpecified
    {
      get { return this._activity_desc != null; }
      set { if (value == (this._activity_desc== null)) this._activity_desc = value ? this.activity_desc : (string)null; }
    }
    private bool ShouldSerializeactivity_desc() { return activity_descSpecified; }
    private void Resetactivity_desc() { activity_descSpecified = false; }
    
    private int? _category;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"category", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int category
    {
      get { return _category?? default(int); }
      set { _category = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool categorySpecified
    {
      get { return this._category != null; }
      set { if (value == (this._category== null)) this._category = value ? this.category : (int?)null; }
    }
    private bool ShouldSerializecategory() { return categorySpecified; }
    private void Resetcategory() { categorySpecified = false; }
    
    private int? _start_time;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int start_time
    {
      get { return _start_time?? default(int); }
      set { _start_time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool start_timeSpecified
    {
      get { return this._start_time != null; }
      set { if (value == (this._start_time== null)) this._start_time = value ? this.start_time : (int?)null; }
    }
    private bool ShouldSerializestart_time() { return start_timeSpecified; }
    private void Resetstart_time() { start_timeSpecified = false; }
    
    private int? _end_time;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"end_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int end_time
    {
      get { return _end_time?? default(int); }
      set { _end_time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool end_timeSpecified
    {
      get { return this._end_time != null; }
      set { if (value == (this._end_time== null)) this._end_time = value ? this.end_time : (int?)null; }
    }
    private bool ShouldSerializeend_time() { return end_timeSpecified; }
    private void Resetend_time() { end_timeSpecified = false; }
    
    private int? _server_now;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"server_now", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int server_now
    {
      get { return _server_now?? default(int); }
      set { _server_now = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool server_nowSpecified
    {
      get { return this._server_now != null; }
      set { if (value == (this._server_now== null)) this._server_now = value ? this.server_now : (int?)null; }
    }
    private bool ShouldSerializeserver_now() { return server_nowSpecified; }
    private void Resetserver_now() { server_nowSpecified = false; }
    
    private int? _type;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private string _notice;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"notice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string notice
    {
      get { return _notice?? ""; }
      set { _notice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool noticeSpecified
    {
      get { return this._notice != null; }
      set { if (value == (this._notice== null)) this._notice = value ? this.notice : (string)null; }
    }
    private bool ShouldSerializenotice() { return noticeSpecified; }
    private void Resetnotice() { noticeSpecified = false; }
    
    private int? _notice_start_time;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"notice_start_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int notice_start_time
    {
      get { return _notice_start_time?? default(int); }
      set { _notice_start_time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool notice_start_timeSpecified
    {
      get { return this._notice_start_time != null; }
      set { if (value == (this._notice_start_time== null)) this._notice_start_time = value ? this.notice_start_time : (int?)null; }
    }
    private bool ShouldSerializenotice_start_time() { return notice_start_timeSpecified; }
    private void Resetnotice_start_time() { notice_start_timeSpecified = false; }
    
    private int? _notice_end_time;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"notice_end_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int notice_end_time
    {
      get { return _notice_end_time?? default(int); }
      set { _notice_end_time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool notice_end_timeSpecified
    {
      get { return this._notice_end_time != null; }
      set { if (value == (this._notice_end_time== null)) this._notice_end_time = value ? this.notice_end_time : (int?)null; }
    }
    private bool ShouldSerializenotice_end_time() { return notice_end_timeSpecified; }
    private void Resetnotice_end_time() { notice_end_timeSpecified = false; }
    
    private int? _interval;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"interval", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int interval
    {
      get { return _interval?? default(int); }
      set { _interval = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool intervalSpecified
    {
      get { return this._interval != null; }
      set { if (value == (this._interval== null)) this._interval = value ? this.interval : (int?)null; }
    }
    private bool ShouldSerializeinterval() { return intervalSpecified; }
    private void Resetinterval() { intervalSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pbActivityList")]
  public partial class pbActivityList : global::ProtoBuf.IExtensible
  {
    public pbActivityList() {}
    
    private readonly global::System.Collections.Generic.List<pb_34.pbActivity> _activity = new global::System.Collections.Generic.List<pb_34.pbActivity>();
    [global::ProtoBuf.ProtoMember(1, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pb_34.pbActivity> activity
    {
      get { return _activity; }
    }
  
    private int? _mails_count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mails_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int mails_count
    {
      get { return _mails_count?? default(int); }
      set { _mails_count = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool mails_countSpecified
    {
      get { return this._mails_count != null; }
      set { if (value == (this._mails_count== null)) this._mails_count = value ? this.mails_count : (int?)null; }
    }
    private bool ShouldSerializemails_count() { return mails_countSpecified; }
    private void Resetmails_count() { mails_countSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pbTwistEggList")]
  public partial class pbTwistEggList : global::ProtoBuf.IExtensible
  {
    public pbTwistEggList() {}
    
    private readonly global::System.Collections.Generic.List<pb_34.pbTwistEgg> _twist_egg = new global::System.Collections.Generic.List<pb_34.pbTwistEgg>();
    [global::ProtoBuf.ProtoMember(1, Name=@"twist_egg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pb_34.pbTwistEgg> twist_egg
    {
      get { return _twist_egg; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}