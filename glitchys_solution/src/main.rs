fn main() {
    // create empty vector (growable collection) and fill it up with 0-100 (who wants to type all that?!)
    let mut v1 = Vec::new();
    let mut v2 = Vec::new();

    // loop through range and use match to build both vectors, insert tuples into v1 in order to
    // determine fizzbuzzbazz later
    for v in 0..=100 {
        match (v, v % 2, v % 5) {
            (0, _, _) => v2.push(0),
            (n, 0, 0) => v1.push((n, 1, 1, 0)),
            (n, 0, _) => v1.push((n, 1, 0, 0)),
            (n, _, 0) => v1.push((n, 0, 1, 0)),
            (n, _, _) => v2.push(n)
        }
    }

    // iterate through fizzbuzz vector, match on each element, and print each element to stdout
    println!("\nNumbers divisible by 2 AND 5:");
    v1.iter().for_each(|v| {
        match v {
            (n, 1, 0, 0) => println!("{} = fizz!", n),
            (n, 0, 1, 0) => println!("{} = buzz!", n),
            (n, 1, 1, 0) => println!("{} = baaz!", n),
            _ => println!("infallible!"),
        }
    });

    // iterate through vector and print each element to stdout
    println!("\nNumbers that are NOT divisible by 2, 5, or 2 AND 5:");
    v2.iter().for_each(|v| println!("{}", v));
}
