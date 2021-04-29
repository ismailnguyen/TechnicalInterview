class Logger {
    fileName;
    functionName;

    error (msg) {
        console.log(msg + ' (' + this.fileName + '.' + this.functionName + ')');
    }
}

Logger.getLogger = function (fileName, functionName) {
    var logger = new Logger();
    logger.fileName = fileName;
    logger.functionName = functionName;

    return logger;
}

exports.Logger = Logger;
