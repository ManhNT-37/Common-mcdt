using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using log4net.Config;
using System.IO;
using System.Diagnostics;
using log4net.Core;
using log4net.Repository.Hierarchy;
using log4net.Appender;
using System.Configuration;

namespace BPMC.Common
{
    public class ApplicationLog : ILog
    {
        ILog dbLog = DBLogService.Service;
        ILog fileLog = LogService.Service;
        private readonly log4net.ILog log4Net;

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

        /// <summary>
        /// Log to file with type Debug
        /// </summary>
        /// <param name="message"></param>
        public void FileDebug(object message)
        {
            fileLog.FileDebug(message);
        }

        /// <summary>
        /// Log to Db with type Debug
        /// </summary>
        /// <param name="message"></param>
        public void DbDebug(object message)
        {
            dbLog.DbDebug(message);
        }

        /// <summary>
        /// Log to file with type Info
        /// </summary>
        /// <param name="message"></param>
        public void FileInfo(object message)
        {
            fileLog.FileInfo(message);
        }

        /// <summary>
        /// Log to Db with type Info
        /// </summary>
        /// <param name="message"></param>
        public void DbInfo(object message)
        {
            dbLog.DbInfo(message);
        }

        /// <summary>
        /// Log to file with type Warn
        /// </summary>
        /// <param name="message"></param>
        public void FileWarn(object message)
        {
            fileLog.FileWarn(message);
        }

        /// <summary>
        /// Log to Db with type Warn
        /// </summary>
        /// <param name="message"></param>
        public void DbWarn(object message)
        {
            dbLog.DbWarn(message);
        }

        /// <summary>
        /// Log to file with type Error
        /// </summary>
        /// <param name="message"></param>
        public void FileError(object message)
        {
            fileLog.FileError(message);
        }

        /// <summary>
        /// Log to db with type Error
        /// </summary>
        /// <param name="message"></param>
        public void DbError(object message)
        {
            dbLog.DbError(message);
        }

        /// <summary>
        /// Log to file with type Debug
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void FileDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            fileLog.FileDebug(message);
        }


        /// <summary>
        /// Log to Db with type Debug
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void DbDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            dbLog.DbDebug(message);
        }

        /// <summary>
        /// Log to file with type Info
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void FileInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            fileLog.FileInfo(message);
        }

        /// <summary>
        /// Log to Db with type Info
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void DbInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            dbLog.DbInfo(message);
        }

        /// <summary>
        /// Log to file with type warn
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void FileWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            fileLog.FileWarn(message);
        }

        /// <summary>
        /// Log to Db with type warn
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void DbWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            dbLog.DbWarn(message);
        }

        /// <summary>
        /// Log to file with type Error
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void FileError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            fileLog.FileError(message);
        }

        /// <summary>
        /// Log to Db with type Error
        /// </summary>
        /// <param name="message">action to log</param>
        /// <param name="userId">userId</param>
        /// <param name="appId">application id</param>
        /// <param name="moduleId">module Id</param>
        /// <param name="content">content</param>
        /// <param name="objectId">Id of Object</param>
        public void DbError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            log4net.LogicalThreadContext.Properties["log_applicationID"] = appId;
            log4net.LogicalThreadContext.Properties["userId"] = userId;
            log4net.LogicalThreadContext.Properties["log_action"] = message;
            log4net.LogicalThreadContext.Properties["moduleId"] = moduleId;
            log4net.LogicalThreadContext.Properties["content"] = content;
            log4net.LogicalThreadContext.Properties["objectId"] = objectId;

            dbLog.DbError(message);
        }

        #endregion
    }
}
