interface ValidLogger {
    error: (msg: string) => any
}

export function failWhale(message?: string, logger: ValidLogger = console) {
    logger.error("▄████████████▄▐█▄▄▄▄█▌")
    logger.error("█████▌▄▌▄▐▐▌██▌▀▀██▀▀")
    logger.error("███▄█▌▄▌▄▐▐▌▀██▄▄█▌")
    logger.error("▄▄▄▄█████████████")

    if (message) {
        logger.error(`\n${message}`)
    }
}
