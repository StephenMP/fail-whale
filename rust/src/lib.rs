use colored::*;

pub fn print() {
    print_whale();
}

pub fn print_with_message(message: &str) {
    print_whale();
    println!("{}", message);
}

fn print_whale() {
    println!("{}", "▄████████████▄▐█▄▄▄▄█▌".red());
    println!("{}", "█████▌▄▌▄▐▐▌██▌▀▀██▀▀".red());
    println!("{}", "███▄█▌▄▌▄▐▐▌▀██▄▄█▌".red());
    println!("{}", "▄▄▄▄█████████████".red());
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_prints() {
        print();
    }

    #[test]
    fn it_prints_with_message() {
        print_with_message("Test");
    }
}
