import React, { useState } from 'react';

const LoginView = () => {

    const submitHandler = (event) => {
        event.preventDefault();
    }

    return(
        <div>
            <form onClick={submitHandler} action="POST" className="form-group">
                <div>
                    <label>Username</label>
                    <input type="text" className="form-control"/>
                </div>
                <div>
                    <label>Password</label>
                    <input type="password" className="form-control" />
                </div>
                <div>
                    <button type="submit" className="btn-primary m-4">Login</button>
                </div>
            </form>
        </div>
    )
};

export default LoginView;