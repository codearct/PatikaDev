import { useState, useEffect } from "react";

import "./styles.css";

import List from "./List";
import Form from "./Form";

function Contacts() {
    const [contacts, setContacts] = useState([
        {
            fullname: "Mehmet Akif Yıldız",
            phone_number: "9876543210"
        },
        {
            fullname: "Asya Yıldız",
            phone_number: "1234567890"
        }
    ])

    useEffect(() => {
        console.log(contacts);
    }, [contacts])

    return (
        <div id="container">
            <h1>Contacts</h1>
            <List contacts={contacts} />
            <Form addContact={setContacts} contacts={contacts} />
        </div>
    )
}

export default Contacts
