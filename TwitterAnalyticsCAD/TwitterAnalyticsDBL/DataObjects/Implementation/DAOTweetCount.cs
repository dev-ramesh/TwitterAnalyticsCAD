/*************************************************************
** Class generated by CodeTrigger, Version 4.8.6.9
** This class was generated on 18-11-2016 02:12:11
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TwitterAnalyticsDBL.DataObjects
{
	public partial class DAOTweetCount : AzureSQLDBConn_BaseData
	{
		#region member variables
		protected Int64? _id;
		protected string _topic;
		protected Int32? _sentimentScore;
		protected string _placeTimeZone;
		protected string _tweetText;
		protected Int32? _retweeted;
		protected Int32? _retweetCount;
		protected DateTime? _createdAt;
		protected Int32? _errorCode;
        protected Int32 _totalCount;
		#endregion

		#region class methods
		public DAOTweetCount()
		{
		}
		
		
		///<Summary>
		///Select all rows
		///This method returns all data rows in the table TweetCount
		///</Summary>
		///<returns>
		///IList-DAOTweetCount.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<DAOTweetCount> SelectAll()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprTweetCount_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("TweetCount");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, null));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				int errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
				if(errorCode > 1)
					throw new Exception("procedure ctprTweetCount_SelectAll returned error code: " + errorCode );

				List<DAOTweetCount> objList = new List<DAOTweetCount>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOTweetCount retObj = new DAOTweetCount();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int64?)null : (Int64?)row["Id"];
						retObj._topic					 = Convert.IsDBNull(row["Topic"]) ? null : (string)row["Topic"];
						retObj._sentimentScore					 = Convert.IsDBNull(row["SentimentScore"]) ? (Int32?)null : (Int32?)row["SentimentScore"];
						retObj._placeTimeZone					 = Convert.IsDBNull(row["PlaceTimeZone"]) ? null : (string)row["PlaceTimeZone"];
						retObj._tweetText					 = Convert.IsDBNull(row["TweetText"]) ? null : (string)row["TweetText"];
						retObj._retweeted					 = Convert.IsDBNull(row["Retweeted"]) ? (Int32?)null : (Int32?)row["Retweeted"];
						retObj._retweetCount					 = Convert.IsDBNull(row["RetweetCount"]) ? (Int32?)null : (Int32?)row["RetweetCount"];
						retObj._createdAt					 = Convert.IsDBNull(row["CreatedAt"]) ? (DateTime?)null : (DateTime?)row["CreatedAt"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

        ///<Summary>
		///Select all rows
		///This method returns all data rows in the table TweetCount
		///</Summary>
		///<returns>
		///IList-DAOTweetCount.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<DAOTweetCount> SelectAllTweetGreaterThanId(long Id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = InlineProcs.ctprTweetCount_SelectAllGreaterThanId;
            command.CommandType = CommandType.Text;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;

            DataTable dt = new DataTable("TweetCount");
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            try
            {
                command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, null));
                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 19, 0, "", DataRowVersion.Proposed, Id));
                staticConnection.Open();
                sqlAdapter.Fill(dt);

                int errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
                if (errorCode > 1)
                    throw new Exception("procedure ctprTweetCount_SelectAll returned error code: " + errorCode);

                List<DAOTweetCount> objList = new List<DAOTweetCount>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DAOTweetCount retObj = new DAOTweetCount();
                        retObj._id = Convert.IsDBNull(row["Id"]) ? (Int64?)null : (Int64?)row["Id"];
                        retObj._topic = Convert.IsDBNull(row["Topic"]) ? null : (string)row["Topic"];
                        retObj._sentimentScore = Convert.IsDBNull(row["SentimentScore"]) ? (Int32?)null : (Int32?)row["SentimentScore"];
                        retObj._placeTimeZone = Convert.IsDBNull(row["PlaceTimeZone"]) ? null : (string)row["PlaceTimeZone"];
                        retObj._tweetText = Convert.IsDBNull(row["TweetText"]) ? null : (string)row["TweetText"];
                        retObj._retweeted = Convert.IsDBNull(row["Retweeted"]) ? (Int32?)null : (Int32?)row["Retweeted"];
                        retObj._retweetCount = Convert.IsDBNull(row["RetweetCount"]) ? (Int32?)null : (Int32?)row["RetweetCount"];
                        retObj._createdAt = Convert.IsDBNull(row["CreatedAt"]) ? (DateTime?)null : (DateTime?)row["CreatedAt"];
                        objList.Add(retObj);
                    }
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }
        }

        ///<Summary>
        ///</Summary>
        ///<returns>
        ///Int32
        ///</returns>
        ///<parameters>
        ///
        ///</parameters>
        public static Int32 SelectAllCount()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprTweetCount_SelectAllCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, null));

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();

				int errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
				if(errorCode > 1)
					throw new Exception("procedure ctprTweetCount_SelectAllCount returned error code: " + errorCode );

				return retCount;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///IList-DAOTweetCount.
		///</returns>
		///<parameters>
		///DAOTweetCount daoTweetCount
		///</parameters>
		public static IList<DAOTweetCount> SelectAllBySearchFields(DAOTweetCount daoTweetCount)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprTweetCount_SelectAllBySearchFields;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("TweetCount");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 19, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.Id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@Topic", SqlDbType.NVarChar, 4000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.Topic?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@SentimentScore", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.SentimentScore?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@PlaceTimeZone", SqlDbType.NVarChar, 4000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.PlaceTimeZone?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@TweetText", SqlDbType.NVarChar, 4000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.TweetText?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@Retweeted", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.Retweeted?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@RetweetCount", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.RetweetCount?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.CreatedAt?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, null));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				int errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
				if(errorCode > 1)
					throw new Exception("procedure ctprTweetCount_SelectAllBySearchFields returned error code: " + errorCode );

				List<DAOTweetCount> objList = new List<DAOTweetCount>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOTweetCount retObj = new DAOTweetCount();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int64?)null : (Int64?)row["Id"];
						retObj._topic					 = Convert.IsDBNull(row["Topic"]) ? null : (string)row["Topic"];
						retObj._sentimentScore					 = Convert.IsDBNull(row["SentimentScore"]) ? (Int32?)null : (Int32?)row["SentimentScore"];
						retObj._placeTimeZone					 = Convert.IsDBNull(row["PlaceTimeZone"]) ? null : (string)row["PlaceTimeZone"];
						retObj._tweetText					 = Convert.IsDBNull(row["TweetText"]) ? null : (string)row["TweetText"];
						retObj._retweeted					 = Convert.IsDBNull(row["Retweeted"]) ? (Int32?)null : (Int32?)row["Retweeted"];
						retObj._retweetCount					 = Convert.IsDBNull(row["RetweetCount"]) ? (Int32?)null : (Int32?)row["RetweetCount"];
						retObj._createdAt					 = Convert.IsDBNull(row["CreatedAt"]) ? (DateTime?)null : (DateTime?)row["CreatedAt"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}


        ///<Summary>
		///</Summary>
		///<returns>
		///IList-DAOTweetCount.
		///</returns>
		///<parameters>
		///DAOTweetCount daoTweetCount
		///</parameters>
		public static IList<DAOTweetCount> TweetCountGetTopics()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = InlineProcs.ctprTweetCount_SelectAllTopics;
            command.CommandType = CommandType.Text;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;

            DataTable dt = new DataTable("TweetCount");
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            try
            {
                command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, null));

                staticConnection.Open();
                sqlAdapter.Fill(dt);

                int errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
                if (errorCode > 1)
                    throw new Exception("procedure ctprTweetCount_SelectAllBySearchFields returned error code: " + errorCode);

                List<DAOTweetCount> objList = new List<DAOTweetCount>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DAOTweetCount retObj = new DAOTweetCount();
                        
                        retObj._topic = Convert.IsDBNull(row["Topic"]) ? null : (string)row["Topic"];
                        retObj._totalCount = Convert.IsDBNull(row["Count"]) ? (Int32)0 : (Int32)row["Count"];
                        objList.Add(retObj);
                    }
                }
                return objList;
            }
            catch
            {
                throw;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }
        }

        ///<Summary>
        ///</Summary>
        ///<returns>
        ///Int32
        ///</returns>
        ///<parameters>
        ///DAOTweetCount daoTweetCount
        ///</parameters>
        public static Int32 SelectAllBySearchFieldsCount(DAOTweetCount daoTweetCount)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprTweetCount_SelectAllBySearchFieldsCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 19, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.Id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@Topic", SqlDbType.NVarChar, 4000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.Topic?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@SentimentScore", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.SentimentScore?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@PlaceTimeZone", SqlDbType.NVarChar, 4000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.PlaceTimeZone?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@TweetText", SqlDbType.NVarChar, 4000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.TweetText?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@Retweeted", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.Retweeted?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@RetweetCount", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.RetweetCount?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoTweetCount.CreatedAt?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, null));

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();

				int errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
				if(errorCode > 1)
					throw new Exception("procedure ctprTweetCount_SelectAllBySearchFieldsCount returned error code: " + errorCode );

				return retCount;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table TweetCount based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Update()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprTweetCount_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, false, 19, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@Topic", SqlDbType.NVarChar, 4000, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_topic?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@SentimentScore", SqlDbType.Int, 4, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, (object)_sentimentScore?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@PlaceTimeZone", SqlDbType.NVarChar, 4000, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_placeTimeZone?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@TweetText", SqlDbType.NVarChar, 4000, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_tweetText?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@Retweeted", SqlDbType.Int, 4, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, (object)_retweeted?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@RetweetCount", SqlDbType.Int, 4, ParameterDirection.InputOutput, true, 10, 0, "", DataRowVersion.Proposed, (object)_retweetCount?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_createdAt?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				command.ExecuteNonQuery();

				_errorCode = (Int32)command.Parameters["@ErrorCode"].Value;
				if(_errorCode > 1)
					throw new Exception("procedure ctprTweetCount_UpdateOne returned error code: " + _errorCode );

				_id					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int64?)null : (Int64?)command.Parameters["@Id"].Value;
				_topic					 = Convert.IsDBNull(command.Parameters["@Topic"].Value) ? null : (string)command.Parameters["@Topic"].Value;
				_sentimentScore					 = Convert.IsDBNull(command.Parameters["@SentimentScore"].Value) ? (Int32?)null : (Int32?)command.Parameters["@SentimentScore"].Value;
				_placeTimeZone					 = Convert.IsDBNull(command.Parameters["@PlaceTimeZone"].Value) ? null : (string)command.Parameters["@PlaceTimeZone"].Value;
				_tweetText					 = Convert.IsDBNull(command.Parameters["@TweetText"].Value) ? null : (string)command.Parameters["@TweetText"].Value;
				_retweeted					 = Convert.IsDBNull(command.Parameters["@Retweeted"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Retweeted"].Value;
				_retweetCount					 = Convert.IsDBNull(command.Parameters["@RetweetCount"].Value) ? (Int32?)null : (Int32?)command.Parameters["@RetweetCount"].Value;
				_createdAt					 = Convert.IsDBNull(command.Parameters["@CreatedAt"].Value) ? (DateTime?)null : (DateTime?)command.Parameters["@CreatedAt"].Value;

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		#endregion

		#region member properties

		public Int64? Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public string Topic
		{
			get
			{
				return _topic;
			}
			set
			{
				_topic = value;
			}
		}

		public Int32? SentimentScore
		{
			get
			{
				return _sentimentScore;
			}
			set
			{
				_sentimentScore = value;
			}
		}

		public string PlaceTimeZone
		{
			get
			{
				return _placeTimeZone;
			}
			set
			{
				_placeTimeZone = value;
			}
		}

		public string TweetText
		{
			get
			{
				return _tweetText;
			}
			set
			{
				_tweetText = value;
			}
		}

		public Int32? Retweeted
		{
			get
			{
				return _retweeted;
			}
			set
			{
				_retweeted = value;
			}
		}

		public Int32? RetweetCount
		{
			get
			{
				return _retweetCount;
			}
			set
			{
				_retweetCount = value;
			}
		}

		public DateTime? CreatedAt
		{
			get
			{
				return _createdAt;
			}
			set
			{
				_createdAt = value;
			}
		}

        public Int32 TotalCount
        {
            get
            {
                return _totalCount;
            }
            set
            {
                _totalCount = value;
            }
        }

        public Int32? ErrorCode
		{
			get
			{
				return _errorCode;
			}
		}

		#endregion
	}
}

#region inline sql procs
namespace TwitterAnalyticsDBL.DataObjects
{
	public partial class InlineProcs
	{
		
		internal static string ctprTweetCount_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			-- returning the error code if any
			SELECT 
			[Id]
			,[Topic]
			,[SentimentScore]
			,[PlaceTimeZone]
			,[TweetText]
			,[Retweeted]
			,[RetweetCount]
			,[CreatedAt]
			FROM [dbo].[TweetCount]          
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";

        internal static string ctprTweetCount_SelectAllGreaterThanId = @"
			-- Select All rows
			-- selects all rows from the table
			-- returning the error code if any
			SELECT 
			[Id]
			,[Topic]
			,[SentimentScore]
			,[PlaceTimeZone]
			,[TweetText]
			,[Retweeted]
			,[RetweetCount]
			,[CreatedAt]
			FROM [dbo].[TweetCount]
            WHERE [Id]>@Id
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";

        internal static string ctprTweetCount_SelectAllCount = @"
			
			-- selects count of all rows from the table
			-- returning the error code if any
			SELECT COUNT(*)
			FROM [dbo].[TweetCount]
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";

		internal static string ctprTweetCount_SelectAllBySearchFields = @"
			
			-- selects all rows from the table according to search criteria
			-- returning the error code if any
			SELECT 
			[Id],
			[Topic],
			[SentimentScore],
			[PlaceTimeZone],
			[TweetText],
			[Retweeted],
			[RetweetCount],
			[CreatedAt]
			FROM [dbo].[TweetCount]
			WHERE 
			([Id] LIKE @Id OR @Id is null)
			AND ([Topic] LIKE @Topic OR @Topic is null)
			AND ([SentimentScore] LIKE @SentimentScore OR @SentimentScore is null)
			AND ([PlaceTimeZone] LIKE @PlaceTimeZone OR @PlaceTimeZone is null)
			AND ([TweetText] LIKE @TweetText OR @TweetText is null)
			AND ([Retweeted] LIKE @Retweeted OR @Retweeted is null)
			AND ([RetweetCount] LIKE @RetweetCount OR @RetweetCount is null)
			AND ([CreatedAt] LIKE @CreatedAt OR @CreatedAt is null)
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";


        internal static string ctprTweetCount_SelectAllTopics = @"
			
			-- selects all rows from the table according to search criteria
			-- returning the error code if any
			SELECT Count(*) as Count,			
			[Topic]
			FROM [dbo].[TweetCount]
			GROUP BY [TOPIC]
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";

        internal static string ctprTweetCount_SelectAllBySearchFieldsCount = @"
			-- Get count of rows returnable by this query
			-- selects count of all rows from the table according to search criteria
			-- returning the error code if any
			SELECT COUNT(*)
			FROM [dbo].[TweetCount]
			WHERE 
			([Id] LIKE @Id OR @Id is null)
			AND ([Topic] LIKE @Topic OR @Topic is null)
			AND ([SentimentScore] LIKE @SentimentScore OR @SentimentScore is null)
			AND ([PlaceTimeZone] LIKE @PlaceTimeZone OR @PlaceTimeZone is null)
			AND ([TweetText] LIKE @TweetText OR @TweetText is null)
			AND ([Retweeted] LIKE @Retweeted OR @Retweeted is null)
			AND ([RetweetCount] LIKE @RetweetCount OR @RetweetCount is null)
			AND ([CreatedAt] LIKE @CreatedAt OR @CreatedAt is null)
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";

		internal static string ctprTweetCount_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			-- returning the error code if any, and the identity field, if any
			
			UPDATE [dbo].[TweetCount]
			SET
			[Topic] = @Topic
			,[SentimentScore] = @SentimentScore
			,[PlaceTimeZone] = @PlaceTimeZone
			,[TweetText] = @TweetText
			,[Retweeted] = @Retweeted
			,[RetweetCount] = @RetweetCount
			,[CreatedAt] = @CreatedAt
			WHERE 
			[Id] = @Id
			SELECT 
			@Id = [Id]
			,@Topic = [Topic]
			,@SentimentScore = [SentimentScore]
			,@PlaceTimeZone = [PlaceTimeZone]
			,@TweetText = [TweetText]
			,@Retweeted = [Retweeted]
			,@RetweetCount = [RetweetCount]
			,@CreatedAt = [CreatedAt]
			FROM [dbo].[TweetCount]
			WHERE 
			[Id] = @Id
			-- returning the error code if any
			SELECT @ErrorCode = @@ERROR
			";

	}
}
#endregion
