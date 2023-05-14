import { useEffect, useState } from "react";

const App = () => {

    // setup useState
    const [tasks, setTasks] = useState([])

    // call api
    useEffect(() => {
        fetch("api/task/GetTasks")
            .then(response => {
                return response.json()
            })
            .then(responseJson => {
                setTasks(responseJson)
            })
    }, [])

    // create div
    return (
        <div className="container">
            <h1>Tasks</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Description</th>
                                <th>CreatedDate</th>
                                <th>ListId</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                tasks.map((item) => (
                                    <tr key="{item}">
                                        <td>{item.id}</td>
                                        <td>{item.description}</td>
                                        <td>{item.createdDate}</td>
                                        <td>{item.listId}</td>
                                    </tr>
                                ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    )
}

export default App;