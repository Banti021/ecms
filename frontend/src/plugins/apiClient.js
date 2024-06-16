import axios from 'axios';

const apiClient = axios.create({
    baseURL: 'http://localhost:5232/api',
    headers: {
        'Content-Type': 'application/json',
    },
});

apiClient.interceptors.request.use((config) => {
    const token = localStorage.getItem('token');
    if (token) {
        config.headers['Authorization'] = `Bearer ${token}`;
    }
    return config;
}, (error) => {
    return Promise.reject(error);
});

export default {
    install(app) {
        app.config.globalProperties.$apiClient = apiClient;
        app.provide('apiClient', apiClient);
    },
    apiClient,
};
