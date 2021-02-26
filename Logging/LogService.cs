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
    public sealed class LogService
    {
        #region privates

        private const string logSectionName = "DanhMuc.API";
        private static readonly LogService instance = new LogService();
        private readonly Log4NetWrapLogger iLog;

        #endregion

        private LogService()
        {
            ConfigureLogging();
            iLog = new Log4NetWrapLogger(LogManager.GetLogger(logSectionName));
        }

        #region business

        /// <summary>
        /// Return logger its log data to file
        /// </summary>
        /// <returns></returns>
        public static ILog Service
        {
            get { return instance.iLog; }
        }

        private static void ConfigureLogging()
        {
            var configSource = new StringBuilder();
            configSource.Append("<log4net>");
            configSource.Append("  <appender name=\"RollingFile\" type=\"log4net.Appender.RollingFileAppender\">");
            configSource.Append("    <param name=\"File\" value=\"C:\\Logs\\BG.PHMC\\BG.PHMC.Log_\" />");
            configSource.Append("    <param name=\"AppendToFile\" value=\"true\" />");
            configSource.Append("    <param name=\"MaxSizeRollBackups\" value=\"10\" />");
            configSource.Append("    <param name=\"MaximumFileSize\" value=\"1024KB\" />");
            configSource.Append("    <param name=\"RollingStyle\" value=\"Composite\" />");
            configSource.Append("    <param name=\"DatePattern\" value=\"yyyy-MM-dd.\\lo\\g\" />");
            configSource.Append("    <param name=\"StaticLogFileName\" value=\"false\" />");
            configSource.Append("    <lockingModel type=\"log4net.Appender.FileAppender+MinimalLock\" />");
            configSource.Append("    <layout type=\"log4net.Layout.PatternLayout\">");
            //configSource.Append("       <param name=\"ConversionPattern\" value=\"%d{HH:mm:ss} %-5p [%logger] %m%newline\" />");
            configSource.Append("       <param name=\"ConversionPattern\" value=\"%d{HH:mm:ss} %-5p %m%newline\" />");
            configSource.Append("    </layout>");
            configSource.Append("  </appender>");
            configSource.Append("  <root>");
            configSource.Append("    <level value=\"ALL\" />");
            configSource.Append("    <appender-ref ref=\"RollingFile\" />");
            configSource.Append("  </root>");
            configSource.Append("</log4net>");

            var output = new MemoryStream();
            var writer = new StreamWriter(output);
            writer.Write(configSource);
            writer.Flush();
            output.Position = 0;
            XmlConfigurator.Configure(output);
            output.Close();
        }

        #endregion
    }

    /// <summary>
    /// Wrapped ILog
    /// </summary>
    internal class Log4NetWrapLogger : ILog
    {
        private readonly log4net.ILog log4Net;

        public Log4NetWrapLogger(log4net.ILog log4Net)
        {
            this.log4Net = log4Net;
        }

        #region ILog Members

        /// <summary>
        /// Log to file with type Debug
        /// </summary>
        /// <param name="message"></param>
        public void FileDebug(object message)
        {
            log4Net.Debug(BuildMessage(message));
            // Console.WriteLine(message);
        }

        /// <summary>
        /// Log to file with type Debug
        /// </summary>
        /// <param name="message"></param>
        public void FileDebug(object message, Exception exception)
        {
            log4Net.Debug(BuildMessage(message), exception);
        }

        /// <summary>
        /// Log to file with type Info
        /// </summary>
        /// <param name="message"></param>
        public void FileInfo(object message)
        {
            log4Net.Info(BuildMessage(message));
        }

        /// <summary>
        /// Log to file with type Info
        /// </summary>
        /// <param name="message"></param>
        public void FileInfo(object message, Exception exception)
        {
            log4Net.Info(BuildMessage(message), exception);
        }

        /// <summary>
        /// Log to file with type Warn
        /// </summary>
        /// <param name="message"></param>
        public void FileWarn(object message)
        {
            log4Net.Warn(BuildMessage(message));
        }

        /// <summary>
        /// Log to file with type Warn
        /// </summary>
        /// <param name="message"></param>
        public void FileWarn(object message, Exception exception)
        {
            log4Net.Warn(BuildMessage(message), exception);
        }

        /// <summary>
        /// Log to file with type Error
        /// </summary>
        /// <param name="message"></param>
        public void FileError(object message)
        {
            log4Net.Error(BuildMessage(message));
        }

        /// <summary>
        /// Log to file with type Error
        /// </summary>
        /// <param name="message"></param>
        public void FileError(object message, Exception exception)
        {
            log4Net.Error(BuildMessage(message), exception);
        }

        /// <summary>
        /// Return log with type Debug is enabled
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return log4Net.IsDebugEnabled; }
        }

        /// <summary>
        /// Return log with type Info is enabled
        /// </summary>
        public bool IsInfoEnabled
        {
            get { return log4Net.IsInfoEnabled; }
        }

        /// <summary>
        /// Return log with type Warn is enabled
        /// </summary>
        public bool IsWarnEnabled
        {
            get { return log4Net.IsWarnEnabled; }
        }

        /// <summary>
        /// Return log with type Error is enabled
        /// </summary>
        public bool IsErrorEnabled
        {
            get { return log4Net.IsErrorEnabled; }
        }

        #endregion

        private static string BuildMessage(object message)
        {
            try
            {
                if (message != null)
                {
                    var aboveFrame = new StackFrame(2);
                    return
                        String.Format("[{0} - {1}] {2}", aboveFrame.GetMethod().ReflectedType.FullName,
                                      aboveFrame.GetMethod().Name, message);
                }
                else
                    return String.Empty;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DbDebug(object message)
        {
            throw new NotImplementedException();
        }

        public void DbInfo(object message)
        {
            throw new NotImplementedException();
        }

        public void DbWarn(object message)
        {
            throw new NotImplementedException();
        }

        public void DbError(object message)
        {
            throw new NotImplementedException();
        }

        public void DbDebug(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            throw new NotImplementedException();
        }

        public void DbInfo(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            throw new NotImplementedException();
        }

        public void DbWarn(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            throw new NotImplementedException();
        }

        public void DbError(string message, Guid userId, Guid appId, Guid moduleId, string content, Guid objectId)
        {
            throw new NotImplementedException();
        }
    }
}
