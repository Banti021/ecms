import axios from 'axios';

const apiClient = axios.create({
    baseURL: 'http://localhost:5232/api', // Replace with your actual base URL
    headers: {
        'Content-Type': 'application/json',
    },
});

export default {
    install(app) {
        app.config.globalProperties.$apiClient = apiClient;
        app.provide('apiClient', apiClient);
    },
};
