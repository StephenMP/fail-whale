export function failWhale(message?: string, logger: any = console) {
    logger.error("▄████████████▄▐█▄▄▄▄█▌")
    logger.error("█████▌▄▌▄▐▐▌██▌▀▀██▀▀")
    logger.error("███▄█▌▄▌▄▐▐▌▀██▄▄█▌")
    logger.error("▄▄▄▄█████████████")

    if (message) {
        logger.error(`\n${message}`)
    }
}
