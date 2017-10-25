using System;
using System.Text;

namespace JL.Core.Models
{
	/// <summary>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserProfile
	{
		public UserProfile()
		{}
		#region Model
		private int _userid;
		private string _username;
		private string _cellphone;
		private bool _iscellphoneconfirmed= false;
		private string _email;
		private bool _isemailconfirmed= false;
		private string _realname;
		private string _nickname;
		private string _telephone;
		private DateTime? _birthday;
		private string _gender;
		private string _qq;
		private string _address;
		private DateTime? _addtime;
		private string _regurl;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cellphone
		{
			set{ _cellphone=value;}
			get{return _cellphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsCellphoneConfirmed
		{
			set{ _iscellphoneconfirmed=value;}
			get{return _iscellphoneconfirmed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsEmailConfirmed
		{
			set{ _isemailconfirmed=value;}
			get{return _isemailconfirmed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gender
		{
			set{ _gender=value;}
			get{return _gender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegUrl
		{
			set{ _regurl=value;}
			get{return _regurl;}
		}
        #endregion Model

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var properties = this.GetType().GetProperties();
            foreach (var p in properties)
            {
                var value = p.GetValue(this);
                sb.AppendFormat("{0}:{1},", p.Name, value);
            }
            return sb.ToString();

            //sb.AppendFormat("Id:{0}", UserId);
            //sb.AppendFormat("UserName:{0}", UserId);
            //sb.AppendFormat("Id:{0}", UserId);
            //sb.AppendFormat("Id:{0}", UserId);
            //sb.AppendFormat("Id:{0}", UserId);
            //sb.AppendFormat("Id:{0}", UserId);
            //sb.AppendFormat("Id:{0}", UserId);
            //return sb.ToString();
        }

    }
}

