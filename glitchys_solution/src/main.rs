fn main() {
    // create empty vector (growable collection) and fill it up with 0-100 (who wants to type all that?!)
    let mut v1 = Vec::new();
    let mut v2 = Vec::new();

    // loop through range and build both vectors
    for v in 0..=100 {
        if v % 2 == 0 && v % 5 == 0 {
            v1.push(v)
        } else {
            v2.push(v)
        }
    };

    // iterate through each list and print each element to stdout
    println!("\nNumbers divisible by 2 AND 5:");
    v1.iter().for_each(|v| println!("{}", v));

    println!("\nNumbers that are NOT divisible by 2 AND 5:");
    v2.iter().for_each(|v| println!("{}", v));
}
