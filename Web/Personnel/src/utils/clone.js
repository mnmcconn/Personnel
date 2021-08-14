export function json(value) {

    if (value==null)
        return null;

    return JSON.parse(JSON.stringify(value));
}