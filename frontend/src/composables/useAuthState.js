import { ref } from 'vue';

const isAuthenticated = ref(false);

export function useAuthState() {
    return {
        isAuthenticated
    };
}
