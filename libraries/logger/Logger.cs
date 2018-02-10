using System;
using SuperSocket.SocketBase.Logging;


namespace Libraries.logger
{

    public class Logger
    {

        private static Logger instance = null;

        ILog Chatlog;
        ILog Maillog;
        ILog Infolog;
        ILog Debuglog;
        ILog Errorlog;
        ILog Fatallog;
        ILog Warnlog;

        public static Logger Instance
        {

            get
            {

                if (instance == null)
                {

                    instance = new Logger();

                }                    

                return instance;

            }

        }

        private Logger()
        {

            Log4NetLogFactory LogFactory = new Log4NetLogFactory();

            Infolog = LogFactory.GetLog("Info");
            Debuglog = LogFactory.GetLog("Debug");
            Errorlog = LogFactory.GetLog("Error");
            Fatallog = LogFactory.GetLog("Fatal");
            Warnlog = LogFactory.GetLog("Warn");
            Chatlog = LogFactory.GetLog("Chat");
            Maillog = LogFactory.GetLog("Mail");

        }


        /// <summary>
        /// Logs the debug message.
        /// 
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Debug(object message)
        {

            Instance.Debuglog.Debug(message);

        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void Debug(object message, Exception exception)
        {

            Instance.Debuglog.Debug(message, exception);

        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void DebugFormat(string format, object arg0)
        {

            Instance.Debuglog.DebugFormat(format, arg0);

        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void DebugFormat(string format, params object[] args)
        {

            Instance.Debuglog.DebugFormat(format, args);

        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Debuglog.DebugFormat(provider, format, args);

        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Error(object message)
        {

            Instance.Errorlog.Error(message);

        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="message">The message.</param><param name="exception">The exception.</param>
        public static void Error(object message, Exception exception)
        {

            Instance.Errorlog.Error(message, exception);

        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param><param name="args">The args.</param>
        public static void ErrorFormat(string format, params object[] args)
        {

            Instance.Errorlog.ErrorFormat(format, args);

        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Errorlog.ErrorFormat(provider, format, args);

        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Fatal(object message)
        {

            Instance.Fatallog.Fatal(message);

        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="message">The message.</param><param name="exception">The exception.</param>
        public static void Fatal(object message, Exception exception)
        {

            Instance.Fatallog.Fatal(message, exception);

        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param><param name="arg0">The arg0.</param>
        public static void FatalFormat(string format, object arg0)
        {

            Instance.Fatallog.FatalFormat(format, arg0);

        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param><param name="args">The args.</param>
        public static void FatalFormat(string format, params object[] args)
        {

            Instance.Fatallog.FatalFormat(format, args);

        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="provider">The provider.</param><param name="format">The format.</param><param name="args">The args.</param>
        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Fatallog.FatalFormat(provider, format, args);

        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Info(object message)
        {

            Instance.Infolog.Info(message);

        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param><param name="exception">The exception.</param>
        public static void Info(object message, Exception exception)
        {

            Instance.Infolog.Info(message, exception);

        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void InfoFormat(string format, object arg0)
        {

            Instance.Infolog.InfoFormat(format, arg0);

        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void InfoFormat(string format, params object[] args)
        {

            Instance.Infolog.InfoFormat(format, args);

        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="provider">The provider.</param><param name="format">The format.</param><param name="args">The args.</param>
        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Infolog.InfoFormat(provider, format, args);

        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Warn(object message)
        {

            Instance.Warnlog.Warn(message);

        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param><param name="exception">The exception.</param>
        public static void Warn(object message, Exception exception)
        {

            Instance.Warnlog.Warn(message, exception);

        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param><param name="arg0">The arg0.</param>
        public static void WarnFormat(string format, object arg0)
        {

            Instance.Warnlog.WarnFormat(format, arg0);

        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param><param name="args">The args.</param>
        public static void WarnFormat(string format, params object[] args)
        {

            Instance.Warnlog.WarnFormat(format, args);

        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="provider">The provider.</param><param name="format">The format.</param><param name="args">The args.</param>
        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Warnlog.WarnFormat(provider, format, args);

        }

        /// <summary>
        /// Logs the chat message.
        /// 
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Chat(object message)
        {

            Instance.Chatlog.Info(message);
            
        }

        /// <summary>
        /// Logs the chat message.
        /// </summary>
        /// <param name="message">The message.</param><param name="exception">The exception.</param>
        public static void Chat(object message, Exception exception)
        {

            Instance.Chatlog.Info(message, exception);
            
        }

        /// <summary>
        /// Logs the chat message.
        /// </summary>
        /// <param name="format">The format.</param><param name="arg0">The arg0.</param>
        public static void ChatFormat(string format, object arg0)
        {

            Instance.Chatlog.InfoFormat(format, arg0);
            
        }

        /// <summary>
        /// Logs the chat message.
        /// </summary>
        /// <param name="format">The format.</param><param name="args">The args.</param>
        public static void ChatFormat(string format, params object[] args)
        {

            Instance.Chatlog.InfoFormat(format, args);
            
        }

        /// <summary>
        /// Logs the chat message.
        /// </summary>
        /// <param name="provider">The provider.</param><param name="format">The format.</param><param name="args">The args.</param>
        public static void ChatFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Chatlog.InfoFormat(provider, format, args);
            
        }

        /// <summary>
        /// Logs the mail message.
        /// 
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Mail(object message)
        {

            Instance.Maillog.Info(message);

        }

        /// <summary>
        /// Logs the mail message.
        /// </summary>
        /// <param name="message">The message.</param><param name="exception">The exception.</param>
        public static void Mail(object message, Exception exception)
        {

            Instance.Maillog.Info(message, exception);

        }

        /// <summary>
        /// Logs the mail message.
        /// </summary>
        /// <param name="format">The format.</param><param name="arg0">The arg0.</param>
        public static void MailFormat(string format, object arg0)
        {

            Instance.Maillog.InfoFormat(format, arg0);

        }

        /// <summary>
        /// Logs the mail message.
        /// </summary>
        /// <param name="format">The format.</param><param name="args">The args.</param>
        public static void MailFormat(string format, params object[] args)
        {

            Instance.Maillog.InfoFormat(format, args);

        }

        /// <summary>
        /// Logs the mail message.
        /// </summary>
        /// <param name="provider">The provider.</param><param name="format">The format.</param><param name="args">The args.</param>
        public static void MailFormat(IFormatProvider provider, string format, params object[] args)
        {

            Instance.Maillog.InfoFormat(provider, format, args);

        }

    }

}