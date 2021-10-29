import { useState, useEffect } from "react";

function Counter() {
    const [number, setNumber] = useState(0);

    useEffect(() => {
        console.log("Component mount edildi");

        const interval = setInterval(() => {
            setNumber((n) => n + 1)
        }, 1000);
        return () => clearInterval(interval);
    }, []);

    useEffect(() => {
        console.log("Number state güncellendi")
    }, [number]);


    return (
        <div >
            <h1>{number}</h1>
            {/* <button onClick={() => setNumber(number + 1)}>Increase</button> */}
        </div>
    )
}

export default Counter;