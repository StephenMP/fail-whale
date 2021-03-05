export function failWhale(message?: string) {
    console.error("▄████████████▄▐█▄▄▄▄█▌")
    console.error("█████▌▄▌▄▐▐▌██▌▀▀██▀▀")
    console.error("███▄█▌▄▌▄▐▐▌▀██▄▄█▌")
    console.error("▄▄▄▄█████████████")

    if (message) {
        console.error(message)
    }
}
