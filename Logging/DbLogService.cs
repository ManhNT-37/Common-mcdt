using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;
using System.Diagnostics;
using log4net.Core;
using log4net.Repository.Hierarchy;
using log4net.Appender;
using System.Configuration;

namespace BPMC.Common
{
    public sealed class DBLogService
    {
        private const string logSectionName = "ADONetAppender";
        private static readonly DBLogService instance = new DBLogService();
        private readonly Log4NetWrapLogger iLog;

        private DBLogService()
        {
            //DBConfigureLogging();
            iLog = new Log4NetWrapLogger(LogManager.GetLogger(logSectionName));
        }

        public static ILog Service
        {
            get { return instance.iLog; }
        }

        internal class Log4NetWrapLogger : ILog
        {
            private readonly log4net.ILog log4Net;

            public Log4NetWrapLogger(log4net.ILog log4Net)
            {
                this.log4Net = log4Net;
            }

            #region ILog Members
            public bool IsDebugEnabled
            {
                get { return log4Net.IsDebugEnabled; }
            }

            public bool IsInfoEnabled
            {
                get { return log4Net.IsInfoEnabled; }
            }

            public bool IsWarnEnabled
            {
                get { return log4Net.IsWarnEnabled; }
            }

            public bool IsErrorEnabled
            {
                get { return log4Net.IsErrorEnabled; }
            }

            public void FileDebug(object message)
            {
                log4Net.Debug(BuildMessage(message));
            }

            public void DbDebug(object message)
            {
                log4Net.Debug(BuildMessage(message));
            }

            public void FileInfo(object message)
            {
                log4Net.Info(BuildMessage(message));
            }

            public void DbInfo(object message)
            {
                log4Net.Info(BuildMessage(message));
            }

            public void FileWarn(object message)
            {
                log4Net.Warn(BuildMessage(message));
            }

            public void DbWarn(object message)
            {
                log4Net.Warn(BuildMessage(message));
            }

            public void FileError(object message)
            {
                log4Net.Error(BuildMessage(message));
            }

            public void DbError(object message)
            {
                log4Net.Error(BuildMessage(message));
            }

            public void FileDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
                log4net.LogicalThreadContext.Properties["userId"] = userId;
                log4net.LogicalThreadContext.Properties["log_action"] = message;
                log4net.LogicalThreadContext.Properties["moduleId"] = Guid.Empty;
                log4net.LogicalThreadContext.Properties["content"] = content;
                log4net.LogicalThreadContext.Properties["objectId"] = objectId;
            }

            public void DbDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            public void FileInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            public void DbInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            public void FileWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            public void DbWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            public void FileError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            public void DbError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
            {
                throw new NotImplementedException();
            }

            #endregion

            private static string BuildMessage(object message)
            {
                var aboveFrame = new StackFrame(2);
                return String.Format("[Class: {0} - Method: {1}] - {2} ", aboveFrame.GetMethod().ReflectedType.FullName,
                                   aboveFrame.GetMethod().Name, message);
            }
   
        }
    }
}
