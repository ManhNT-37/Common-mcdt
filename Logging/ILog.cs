using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;
using log4net.Appender;

namespace BPMC.Common
{
   public interface ILog
    {
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        void FileDebug(object message);
        void DbDebug(object message);
        void FileInfo(object message);
        void DbInfo(object message);
        void FileWarn(object message);
        void DbWarn(object message);
        void FileError(object message);
        void DbError(object message);
        // void FileDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        void DbDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        // void FileInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        void DbInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        // void FileWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        void DbWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        // void FileError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
        void DbError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId);
    }
}
