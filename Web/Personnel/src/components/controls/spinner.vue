<template>
    <div v-if="mini">
        <table>
            <tr>
                <td align="center">
                    <span class="loader load-smaller"></span>
                </td>
            </tr>
        </table>
    </div>
    <div v-else>
        <table class="width-100p margin-top-30 margin-bottom-30">
            <tr>
                <td align="center">
                    <span class="loader load-large"></span>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <span class="small italic text-muted">
                        {{message}}
                    </span>
                </td>
            </tr>
        </table>
    </div>
</template>

<script>
    export default {
        name: "spinner",
        props: {
            msg: {
                type: String,
                required: false,
                default: () => ''
            },
            mini: {
                type: Boolean,
                required: false,
                default: () => false
            }
        },
        data() {
            return {
                message: this.msg
            }
        }
    }
</script>